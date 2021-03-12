/// <summary>
/// Nova requisição
/// </summary>
NTSTATUS IrpMjCreate(
	PDEVICE_OBJECT Device,
	PIRP Irp
)
{
	// Status de sucesso
	Irp->IoStatus.Status = STATUS_SUCCESS;
	Irp->IoStatus.Information = 0;

	// Complete a requisição
	IoCompleteRequest(Irp, IO_NO_INCREMENT);
	return STATUS_SUCCESS;
}

/// <summary>
/// Requisição fechada
/// </summary>
NTSTATUS IrpMjClose(
	PDEVICE_OBJECT Device,
	PIRP Irp
)
{
	// Status de sucesso
	Irp->IoStatus.Status = STATUS_SUCCESS;
	Irp->IoStatus.Information = 0;

	// Complete a requisição
	IoCompleteRequest(Irp, IO_NO_INCREMENT);
	return STATUS_SUCCESS;
}

/// <summary>
/// DeviceControl
/// </summary>
NTSTATUS IrpMjDeviceControl(
	PDEVICE_OBJECT Device,
	PIRP Irp
)
{
	// Obtenha o IRP atual
	PIO_STACK_LOCATION Io = IoGetCurrentIrpStackLocation(Irp);
	NTSTATUS Status;

	// Mensagem para retornar ao user-mode
	CHAR*  StatusString = "fail!";

	// Informação, ele seta a quantidade máxima de caracterias
	// Permitido na função RtlCopyMemory para enviar ao user-mode
	Irp->IoStatus.Information = 10;

	// Mensagem do user-mode
	PCHAR MessageUser = (PCHAR)Irp->AssociatedIrp.SystemBuffer;

	// Se for para deletar algum arquivo
	if (Io->Parameters.DeviceIoControl.IoControlCode == DELETE_FILE_W)
	{
		// Se conseguir deletar o arquivo
		if (NT_SUCCESS(DeleteFile(MessageUser, FALSE)))
		{
			// Altere a mensagem para enviar ao user-mode
			StatusString = "success!";
		}
	}

	// Se for para criar um arquivo
	else if (Io->Parameters.DeviceIoControl.IoControlCode == CREATE_FILE_W)
	{
		// Se conseguir criar o arquivo
		if (NT_SUCCESS(CreateFile(MessageUser, FALSE)))
		{
			// Altere a mensagem para enviar ao user-mode
			StatusString = "success!";
		}
	}

	// Se for para deletar um valor no registro
	else if (Io->Parameters.DeviceIoControl.IoControlCode == DELETE_REG_W)
	{
		// Se conseguir deletar um valor no registro
		if (NT_SUCCESS(DeleteReg(MessageUser)))
		{
			// Altere a mensagem para enviar ao user-mode
			StatusString = "success!";
		}
	}

	// Se for para criar um valor (pasta) no registro
	else if (Io->Parameters.DeviceIoControl.IoControlCode == CREATE_REG_W)
	{
		// Se conseguir criar um valor no registro
		if (NT_SUCCESS(CreateReg(MessageUser)))
		{
			// Altere a mensagem para enviar ao user-mode
			StatusString = "success!";
		}
	}

	// Se for para travar o sistema
	else if (Io->Parameters.DeviceIoControl.IoControlCode == CRASH_SYSTEM_W)
	{
		// Trave o sistema
		PCHAR String = "";

		// Agora, trave o sistema
		String = 0;
		*String = "a";
	}

	// Se for para negar novos processos
	else if (Io->Parameters.DeviceIoControl.IoControlCode == DENY_NEW_PROCESSES_W)
	{
		// Altere o valor
		DenyProcess = !DenyProcess;

		// Altere a mensagem para enviar ao user-mode
		StatusString = "success!";
	}

	// Se for para deletar alguma pasta
	if (Io->Parameters.DeviceIoControl.IoControlCode == DELETE_FOLDER_W)
	{
		// Se conseguir deletar a pasta
		if (NT_SUCCESS(DeleteFile(MessageUser, TRUE)))
		{
			// Altere a mensagem para enviar ao user-mode
			StatusString = "success!";
		}
	}

	// Se for para criar uma pasta
	else if (Io->Parameters.DeviceIoControl.IoControlCode == CREATE_FOLDER_W)
	{
		// Se conseguir criar uma pasta
		if (NT_SUCCESS(CreateFile(MessageUser, TRUE)))
		{
			// Altere a mensagem para enviar ao user-mode
			StatusString = "success!";
		}
	}

	// Limite máximo de caracterias para a função RtlCopyMemory
	// Porque se não haver, vai retornar "lixo", por padrão, o falor é 6, igual o 'fail!'
	int MaxLengthToCopy = 6;

	// Se for a mensagem de sucesso
	if (StatusString == "success!")
	{
		// Altere o limite máximo
		MaxLengthToCopy = 9;
	}

	// Copie a mensagem para a memória do user-mode
	RtlCopyMemory(
		// Vamos enviar pra cá
		Irp->AssociatedIrp.SystemBuffer,

		// Status
		StatusString,

		// Tamanho máximo da mensagem para retornar
		MaxLengthToCopy
	);

	// Status de sucesso
	Irp->IoStatus.Status = STATUS_SUCCESS;

	// Complete a requisição
	IoCompleteRequest(Irp, IO_NO_INCREMENT);

	return STATUS_SUCCESS;

}

