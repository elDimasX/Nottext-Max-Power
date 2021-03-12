///
/// Funções de arquivos, como deletar, copiar e etc
/// 

/// <summary>
/// Função que cria um arquivo
/// </summary>
NTSTATUS CreateFile(PCHAR FileName, BOOLEAN IsDirectory)
{
	// Status
	NTSTATUS Status;

	// Unicode e Ansi
	UNICODE_STRING Unicode;
	ANSI_STRING Ansi;

	// Inicie o ANSI_STRING
	RtlInitAnsiString(
		&Ansi,

		// Valor
		FileName
	);

	// Inicie o UNICODE_STRING
	RtlAnsiStringToUnicodeString(
		// Inicie ele
		&Unicode,

		// Com esse ANSI_STRING
		&Ansi,

		// Aloque um espaço na memória
		TRUE
	);

	// Atributos
	OBJECT_ATTRIBUTES Attrib;

	// Inicie os atributos para detectar o arquivo
	InitializeObjectAttributes(
		// Inicie ele
		&Attrib,

		// Nome do arquivo
		&Unicode,

		// Parâmetros
		OBJ_KERNEL_HANDLE | OBJ_CASE_INSENSITIVE,
		NULL,
		NULL
	);

	// Uma alça, vamos usa-la para fechar o arquivo depois
	HANDLE FileHandle;

	// Status
	IO_STATUS_BLOCK Io;

	// É uma pasta
	if (IsDirectory == TRUE)
	{
		// Removi os comentários porque logo a baixo, há este código todo comentado
		Status = ZwCreateFile(
			&FileHandle,
			FILE_LIST_DIRECTORY,
			&Attrib,
			&Io,
			NULL,
			FILE_ATTRIBUTE_NORMAL,
			0,
			FILE_CREATE,
			FILE_DIRECTORY_FILE,
			NULL,
			0
		);
	}

	// Não é uma pasta, então, crie um arquivo
	else {
		// Agora, crie o arquivo
		Status = ZwCreateFile(
			// Salve a alça
			&FileHandle,

			// Adicione o texto que já tem
			FILE_APPEND_DATA,

			// Atributos
			&Attrib,

			// Acesso
			&Io,
			NULL,

			// Atributo normal
			FILE_ATTRIBUTE_NORMAL,
			0,

			// Aqui possui várias opções como: FILE_CREATE, FILE_CREATED, FILE_OPEN_IF e etc
			// Mas queremos criar um arquivo
			FILE_CREATE,

			// Sicronize
			FILE_SYNCHRONOUS_IO_NONALERT,
			NULL,
			0
		);
	}

	// Se conter sucesso
	if (NT_SUCCESS(Status))
	{
		// Feche a alça para liberar acesso ao arquivo
		ZwClose(FileHandle);
	}

	// Libere o UNICODE_STRING que a gente alocou
	RtlFreeUnicodeString(&Unicode);

	// Retorne o status
	return Status;
}

/// <summary>
/// Função que deleta um arquivo
/// </summary>
NTSTATUS DeleteFile(PCHAR FileName, BOOLEAN IsDirectory)
{
	// Status
	NTSTATUS Status;

	// UNICODE e ANSI
	UNICODE_STRING Unicode;
	ANSI_STRING Ansi;

	// Inicie o ANSI_STRING
	RtlInitAnsiString(
		// Inicie ele
		&Ansi,

		// Valor
		FileName
	);

	// Inicie o UNICODE_STRING
	RtlAnsiStringToUnicodeString(
		// UNICODE
		&Unicode,

		// ANSI_STRING
		&Ansi,

		// Aloque um espaço na memória
		TRUE
	);

	// Atributos
	OBJECT_ATTRIBUTES Attrib;

	// Inicie os atributos para detectar o arquivo
	InitializeObjectAttributes(
		// Inicie aqui
		&Attrib,

		// Nome do arquivo
		&Unicode,

		// Algum parâmetros
		OBJ_CASE_INSENSITIVE | OBJ_KERNEL_HANDLE,
		NULL,
		NULL
	);

	// Alça pra abrir o arquivo
	HANDLE FileHandle;
	IO_STATUS_BLOCK Io;

	// Objeto
	DEVICE_OBJECT* Device = NULL;

	// A rotina a seguir é usada por drivers de filtro do sistema de arquivos para enviar
	// Uma solicitação de criação apenas para os filtros abaixo de um objeto de
	// Dispositivo especificado e para o sistema de arquivos.
	// Os filtros anexados acima do objeto de dispositivo especificado na
	// pilha do driver não recebem a solicitação de criação. 

	if (IsDirectory == TRUE)
	{
		// Removi os comentários aqui, porque logo a baixo, há um ELSE
		// Que contém eles
		Status = IoCreateFileSpecifyDeviceObjectHint(
			&FileHandle,
			FILE_LIST_DIRECTORY,
			&Attrib,
			&Io,
			NULL,
			FILE_ATTRIBUTE_NORMAL,
			0,
			FILE_OPEN,
			FILE_DIRECTORY_FILE,
			NULL,
			NULL,
			CreateFileTypeNone,
			NULL,
			IO_IGNORE_SHARE_ACCESS_CHECK | IO_IGNORE_READONLY_ATTRIBUTE,
			Device
		);
	}

	// Não é uma pasta
	else {
		Status = IoCreateFileSpecifyDeviceObjectHint(
			// Salve a alça aqui
			&FileHandle,

			// Permissão para deletar
			DELETE,

			// Os atributos
			&Attrib,

			//  Um ponteiro para uma IO_STATUS_BLOCK estrutura que recebe o status de
			// conclusão final e informações sobre a operação solicitada.
			// No retorno de IoCreateFileSpecifyDeviceObjectHint ,
			// o Information membro contém um dos seguintes valores:
			// FILE_CREATED / FILE_OPENED / FILE_OVERWRITTEN /FILE_SUPERSEDED
			// O ARQUIVO EXISTE / ARQUIVO NÃO EXISTE
			&Io,
			NULL,

			// Atributos normal
			FILE_ATTRIBUTE_NORMAL,

			// "Para solicitar acesso exclusivo, defina este parâmetro como zero"
			0,

			// Abra o arquivo, não crie um
			FILE_OPEN,

			// Mais sobre aqui: 
			// https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/ntddk/nf-ntddk-iocreatefilespecifydeviceobjecthint
			FILE_NON_DIRECTORY_FILE | FILE_SYNCHRONOUS_IO_NONALERT,
			NULL,
			NULL,

			// Os drivers devem definir este parâmetro como CreateFileTypeNone.
			CreateFileTypeNone,
			NULL, // Os drivers devem definir este parâmetro como NULL . 

			// Especifica as opções a serem usadas durante a criação da solicitação de criação.
			IO_IGNORE_SHARE_ACCESS_CHECK | IO_IGNORE_READONLY_ATTRIBUTE,

			// Dispositivo
			Device
		);
	}
	
	
	// Se conseguir chamar a função
	if (NT_SUCCESS(Status))
	{
		// Se for um arquivo, execute o código a seguir, que permite deletar arquivos em execução
		if (IsDirectory == FALSE)
		{
			// Objeto
			FILE_OBJECT* Object = NULL;

			// A ObReferenceObjectByHandle rotina fornece validação de acesso no identificador
			// Do objeto e, se o acesso puder ser concedido, retorna o ponteiro correspondente
			// Para o corpo do objeto, ou seja, isso permite deletar um arquivo em uso. 
			Status = ObReferenceObjectByHandle(
				// Alça, lembra que usamos ela?
				FileHandle,
				0,
				0,

				// Modo kernel
				KernelMode,

				// Ponteiro para uma variável que recebe um ponteiro para o corpo do objeto.
				(PVOID*)&Object,
				NULL
			);

			// Se obter sucesso, continue o código
			if (NT_SUCCESS(Status))
			{
				// Ponteiro opaco para um objeto de seção de imagem
				// ou seja, uma CONTROL_AREA estrutura que é usado para rastrear informações
				// De estado para um fluxo de arquivo executável.
				// O gerenciador de memória define este membro sempre que uma seção de imagem
				// Executável é criada para o fluxo.
				// Um NULL valor indica que a imagem executável está não na memória;
				// este valor, entretanto, pode mudar a qualquer momento. 
				Object->SectionObjectPointer->ImageSectionObject = 0;

				// Um membro somente leitura.
				// Se TRUE, o arquivo associado ao objeto de arquivo foi aberto para acesso
				// De exclusão.
				// Se FALSE, o arquivo foi aberto sem acesso de exclusão.
				// Essas informações são usadas ao verificar e / ou definir o acesso de
				// compartilhamento do arquivo.
				Object->DeleteAccess = 1;

				// Libere o OBJECT
				ObDereferenceObject(Object);
			}
		}

		// Se tudo ocorrer bem
		if (NT_SUCCESS(Status))
		{
			// Libere a alça
			ZwClose(FileHandle);

			// Agora, delete o arquivo
			Status = ZwDeleteFile(&Attrib);
		}

		// Se falhar, libere o arquivo
		else {

			// Libere a alça do arquivo
			ZwClose(FileHandle);
		}
	}

	// Libere o UNICODE_STRING que a gente alocou
	RtlFreeUnicodeString(&Unicode);

	// Retorne o status
	return Status;
}
