///
/// Arquivo global, onde tem todas as funções e etc
///

// Incluir o arquivo
#include <fltKernel.h>
#include <NTNLS.H>

#include "files.h"
#include "reg.h"

// DeviceName & SymbolicName para a comunicação entre o kernel e user-mode
UNICODE_STRING DeviceName = RTL_CONSTANT_STRING(L"\\Device\\MaxPower");
UNICODE_STRING SymLinkName = RTL_CONSTANT_STRING(L"\\??\\MaxPower");

// Saber se deve negar ou não novos processos
BOOLEAN DenyProcess = FALSE;

// IOCTL para deletar um valor no registro
#define DELETE_REG_W CTL_CODE(FILE_DEVICE_UNKNOWN, 0x2510, METHOD_BUFFERED, FILE_ANY_ACCESS)

// IOCTL para criar um valor no registro
#define CREATE_REG_W CTL_CODE(FILE_DEVICE_UNKNOWN, 0x2520, METHOD_BUFFERED, FILE_ANY_ACCESS)

// IOCTL para crashar o sistema
#define CRASH_SYSTEM_W CTL_CODE(FILE_DEVICE_UNKNOWN, 0x2530, METHOD_BUFFERED, FILE_ANY_ACCESS)

// IOCTL para negar novos processos
#define DENY_NEW_PROCESSES_W CTL_CODE(FILE_DEVICE_UNKNOWN, 0x2540, METHOD_BUFFERED, FILE_ANY_ACCESS)

// IOCTL para deletar um arquivo
#define DELETE_FILE_W CTL_CODE(FILE_DEVICE_UNKNOWN, 0x2500, METHOD_BUFFERED, FILE_ANY_ACCESS)

// IOCTL para criar um arquivo
#define CREATE_FILE_W CTL_CODE(FILE_DEVICE_UNKNOWN, 0x2505, METHOD_BUFFERED, FILE_ANY_ACCESS)

// IOCTL para deletar uma pasta
#define DELETE_FOLDER_W CTL_CODE(FILE_DEVICE_UNKNOWN, 0x2550, METHOD_BUFFERED, FILE_ANY_ACCESS)

// IOCTL para criar uma pasta
#define CREATE_FOLDER_W CTL_CODE(FILE_DEVICE_UNKNOWN, 0x2555, METHOD_BUFFERED, FILE_ANY_ACCESS)

// Objeto global
PDEVICE_OBJECT DeviceObject;

/// <summary>
/// Após uma requisição for criada
/// </summary>
NTSTATUS IrpMjCreate(
	PDEVICE_OBJECT Device,
	PIRP Irp
);

/// <summary>
/// Após uma requisição for fechada, ocorre depois que o user-mode envia a mensagem
/// </summary>
NTSTATUS IrpMjClose(
	PDEVICE_OBJECT Device,
	PIRP Irp
);

/// <summary>
/// Quando o user-mode enviar uma mensagem
/// </summary>
NTSTATUS IrpMjDeviceControl(
	PDEVICE_OBJECT Device,
	PIRP Irp
);

/// <summary>
/// Inicia o driver
/// </summary>
NTSTATUS DriverEntry(
	PDRIVER_OBJECT DriverObject,
	PUNICODE_STRING RegistryPath
);

/// <summary>
/// Descarrega o driver
/// </summary>
VOID Unload(
	PDRIVER_OBJECT DriverObject
);

/// <summary>
/// Novo processo detectado
/// </summary>
VOID NewProcess(
	PEPROCESS Process,
	HANDLE PidProcess,
	PPS_CREATE_NOTIFY_INFO Info
);
