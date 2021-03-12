///
/// Driver de kernel para o Nottext Max Power - 2021
///

#include "header.h"
#include "irps.h"

/// <summary>
/// Descarrega o driver
/// </summary>
VOID Unload(
	PDRIVER_OBJECT DriverObject
)
{
	// Agora, remova a monitoração de novos processos
	PsSetCreateProcessNotifyRoutineEx(NewProcess, TRUE);

	// Delete o dispositivo
	IoDeleteDevice(DeviceObject);

	// Delete o link
	IoDeleteSymbolicLink(&SymLinkName);
}

/// <summary>
/// Novo processo detectado
/// </summary>
VOID NewProcess(
	PEPROCESS Process,
	HANDLE PidProcess,
	PPS_CREATE_NOTIFY_INFO Info
)
{
	// Se um novo processo for detectado
	if (Info)
	{
		// Se for para impedir novos processos
		if (DenyProcess == TRUE)
		{
			// Negue o acesso
			Info->CreationStatus = STATUS_ACCESS_DENIED;
		}

		// Se não
		else {
			// Permita o processo
			Info->CreationStatus = STATUS_SUCCESS;
		}
	}
}

/// <summary>
/// Essa função será chamada após o driver carregar
/// </summary>
NTSTATUS DriverEntry(
	PDRIVER_OBJECT DriverObject,
	PUNICODE_STRING RegistryPath
)
{
	// Configure que o driver pode ser descarregado
	DriverObject->DriverUnload = Unload;

	// Status
	NTSTATUS Status;

	// Crie um dispositivo pra comunicação
	Status = IoCreateDevice(
		// DriverObject
		DriverObject,
		0,

		// Nome
		&DeviceName,

		// Não sei pra que serve
		FILE_DEVICE_UNKNOWN,
		FILE_DEVICE_SECURE_OPEN,
		FALSE,

		// Salve aqui, para que possamos deletar ele depois
		&DeviceObject
	);


	// Se for sucesso
	if (NT_SUCCESS(Status))
	{
		// Crie o link simbolico
		Status = IoCreateSymbolicLink(&SymLinkName, &DeviceName);

		// Se falhar
		if (!NT_SUCCESS(Status))
		{
			// Delete o dispositivo
			IoDeleteDevice(DeviceObject);
		}

		else {

			// Configure as mensagens

			// Após criar uma requisição
			DriverObject->MajorFunction[IRP_MJ_CREATE] = IrpMjCreate;

			// Após fechar uma requisição
			DriverObject->MajorFunction[IRP_MJ_CLOSE] = IrpMjClose;

			// Após enviar uma mensagem
			DriverObject->MajorFunction[IRP_MJ_DEVICE_CONTROL] = IrpMjDeviceControl;

		}
	}

	// Agora, instale a monitoração de novos processos
	Status = PsSetCreateProcessNotifyRoutineEx(NewProcess, FALSE);

	// Retorne o status
	return Status;
}

