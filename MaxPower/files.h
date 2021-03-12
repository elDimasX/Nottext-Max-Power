///
/// Fun��es de arquivos, como deletar, copiar e etc
/// 

/// <summary>
/// Fun��o que cria um arquivo
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

		// Aloque um espa�o na mem�ria
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

		// Par�metros
		OBJ_KERNEL_HANDLE | OBJ_CASE_INSENSITIVE,
		NULL,
		NULL
	);

	// Uma al�a, vamos usa-la para fechar o arquivo depois
	HANDLE FileHandle;

	// Status
	IO_STATUS_BLOCK Io;

	// � uma pasta
	if (IsDirectory == TRUE)
	{
		// Removi os coment�rios porque logo a baixo, h� este c�digo todo comentado
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

	// N�o � uma pasta, ent�o, crie um arquivo
	else {
		// Agora, crie o arquivo
		Status = ZwCreateFile(
			// Salve a al�a
			&FileHandle,

			// Adicione o texto que j� tem
			FILE_APPEND_DATA,

			// Atributos
			&Attrib,

			// Acesso
			&Io,
			NULL,

			// Atributo normal
			FILE_ATTRIBUTE_NORMAL,
			0,

			// Aqui possui v�rias op��es como: FILE_CREATE, FILE_CREATED, FILE_OPEN_IF e etc
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
		// Feche a al�a para liberar acesso ao arquivo
		ZwClose(FileHandle);
	}

	// Libere o UNICODE_STRING que a gente alocou
	RtlFreeUnicodeString(&Unicode);

	// Retorne o status
	return Status;
}

/// <summary>
/// Fun��o que deleta um arquivo
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

		// Aloque um espa�o na mem�ria
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

		// Algum par�metros
		OBJ_CASE_INSENSITIVE | OBJ_KERNEL_HANDLE,
		NULL,
		NULL
	);

	// Al�a pra abrir o arquivo
	HANDLE FileHandle;
	IO_STATUS_BLOCK Io;

	// Objeto
	DEVICE_OBJECT* Device = NULL;

	// A rotina a seguir � usada por drivers de filtro do sistema de arquivos para enviar
	// Uma solicita��o de cria��o apenas para os filtros abaixo de um objeto de
	// Dispositivo especificado e para o sistema de arquivos.
	// Os filtros anexados acima do objeto de dispositivo especificado na
	// pilha do driver n�o recebem a solicita��o de cria��o. 

	if (IsDirectory == TRUE)
	{
		// Removi os coment�rios aqui, porque logo a baixo, h� um ELSE
		// Que cont�m eles
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

	// N�o � uma pasta
	else {
		Status = IoCreateFileSpecifyDeviceObjectHint(
			// Salve a al�a aqui
			&FileHandle,

			// Permiss�o para deletar
			DELETE,

			// Os atributos
			&Attrib,

			//  Um ponteiro para uma IO_STATUS_BLOCK estrutura que recebe o status de
			// conclus�o final e informa��es sobre a opera��o solicitada.
			// No retorno de IoCreateFileSpecifyDeviceObjectHint ,
			// o Information membro cont�m um dos seguintes valores:
			// FILE_CREATED / FILE_OPENED / FILE_OVERWRITTEN /FILE_SUPERSEDED
			// O ARQUIVO EXISTE / ARQUIVO N�O EXISTE
			&Io,
			NULL,

			// Atributos normal
			FILE_ATTRIBUTE_NORMAL,

			// "Para solicitar acesso exclusivo, defina este par�metro como zero"
			0,

			// Abra o arquivo, n�o crie um
			FILE_OPEN,

			// Mais sobre aqui: 
			// https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/ntddk/nf-ntddk-iocreatefilespecifydeviceobjecthint
			FILE_NON_DIRECTORY_FILE | FILE_SYNCHRONOUS_IO_NONALERT,
			NULL,
			NULL,

			// Os drivers devem definir este par�metro como CreateFileTypeNone.
			CreateFileTypeNone,
			NULL, // Os drivers devem definir este par�metro como NULL . 

			// Especifica as op��es a serem usadas durante a cria��o da solicita��o de cria��o.
			IO_IGNORE_SHARE_ACCESS_CHECK | IO_IGNORE_READONLY_ATTRIBUTE,

			// Dispositivo
			Device
		);
	}
	
	
	// Se conseguir chamar a fun��o
	if (NT_SUCCESS(Status))
	{
		// Se for um arquivo, execute o c�digo a seguir, que permite deletar arquivos em execu��o
		if (IsDirectory == FALSE)
		{
			// Objeto
			FILE_OBJECT* Object = NULL;

			// A ObReferenceObjectByHandle rotina fornece valida��o de acesso no identificador
			// Do objeto e, se o acesso puder ser concedido, retorna o ponteiro correspondente
			// Para o corpo do objeto, ou seja, isso permite deletar um arquivo em uso. 
			Status = ObReferenceObjectByHandle(
				// Al�a, lembra que usamos ela?
				FileHandle,
				0,
				0,

				// Modo kernel
				KernelMode,

				// Ponteiro para uma vari�vel que recebe um ponteiro para o corpo do objeto.
				(PVOID*)&Object,
				NULL
			);

			// Se obter sucesso, continue o c�digo
			if (NT_SUCCESS(Status))
			{
				// Ponteiro opaco para um objeto de se��o de imagem
				// ou seja, uma CONTROL_AREA estrutura que � usado para rastrear informa��es
				// De estado para um fluxo de arquivo execut�vel.
				// O gerenciador de mem�ria define este membro sempre que uma se��o de imagem
				// Execut�vel � criada para o fluxo.
				// Um NULL valor indica que a imagem execut�vel est� n�o na mem�ria;
				// este valor, entretanto, pode mudar a qualquer momento. 
				Object->SectionObjectPointer->ImageSectionObject = 0;

				// Um membro somente leitura.
				// Se TRUE, o arquivo associado ao objeto de arquivo foi aberto para acesso
				// De exclus�o.
				// Se FALSE, o arquivo foi aberto sem acesso de exclus�o.
				// Essas informa��es s�o usadas ao verificar e / ou definir o acesso de
				// compartilhamento do arquivo.
				Object->DeleteAccess = 1;

				// Libere o OBJECT
				ObDereferenceObject(Object);
			}
		}

		// Se tudo ocorrer bem
		if (NT_SUCCESS(Status))
		{
			// Libere a al�a
			ZwClose(FileHandle);

			// Agora, delete o arquivo
			Status = ZwDeleteFile(&Attrib);
		}

		// Se falhar, libere o arquivo
		else {

			// Libere a al�a do arquivo
			ZwClose(FileHandle);
		}
	}

	// Libere o UNICODE_STRING que a gente alocou
	RtlFreeUnicodeString(&Unicode);

	// Retorne o status
	return Status;
}
