
///
/// Arquivo com as funções e importações de DLL
///

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Nottext_Max_Power
{
    class Communication
    {
        /// <summary>
        /// Envia a mensagem ao kernel mode
        /// </summary>
        public static void SendMessage(string message, uint ctl)
        {
            // Crie um arquivo, necessário para outras
            // Operações depois
            IntPtr device = (IntPtr)CreateFile(
                "\\\\.\\MaxPower", // Nome do dispositivo
                GENERIC_READ | GENERIC_WRITE, // Escrita
                FILE_SHARE_READ | FILE_SHARE_WRITE, // Escrita
                IntPtr.Zero,
                OPEN_EXISTING, // Abra o que já existe
                0,
                0
            );

            // Novos bytes
            int uCnt = 10;

            // Mensagem para o kernel
            StringBuilder sendToKernel = new StringBuilder(message);

            // Mensagem para receber do kernel
            StringBuilder reciveToKernel = new StringBuilder();

            // Envie a mensagem para o kernel
            DeviceIoControl(
                device, // Dispositivo
                ctl, // Que tipo de mensagem
                sendToKernel, // Mensagem para o kernel

                // Tamanho da mensagem enviada, não sei porque, mas após eu adicionar
                // + 5, o kernel sempre recebe a mensagem sem "lixo", por isso, deixei ai
                sendToKernel.Length + 5,

                reciveToKernel, //Receber mensagem do kernel
                1, // Length (não tem importancia kk), só deixar 1 pra receber as mensagens

                ref uCnt,
                IntPtr.Zero
            );

            // Obtenha a mensagem
            //string s = Marshal.PtrToStringAnsi((IntPtr)reciveToKernel);

            // Se for sucesso
            if (reciveToKernel.ToString() == "success!")
            {
                // Failbox
                Failbox failbox = new Failbox("The operation was successful!", true);

                // Mostre
                failbox.ShowDialog();
            }
            
            // Se falhar
            else
            {
                // Failbox
                Failbox failbox = new Failbox("The operation was not completed.", false);

                // Mostre
                failbox.ShowDialog();
            }

            // Feche o dispositivo
            CloseHandle(
                device
            );
        }

        /// <summary>
        /// Importação da DLL KERNEL32.DLL CreateFile
        /// </summary>
        /// <returns></returns>
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int CreateFile(
            String lpFileName, // Nome da porta
            int dwDesiredAccess, // Acesso
            int dwShareMode, // Compartilhamento
            IntPtr lpSecurityAttributes, // Security
            int dwCreationDisposition, // Disposition
            int dwFlagsAndAttributes, // Atributos
            int hTemplateFile // Arquivo
        );

        /// <summary>
        /// Fechar o dispositivo
        /// </summary>
        [DllImport("kernel32", SetLastError = true)]
        static extern bool CloseHandle(
            IntPtr handle // O que fechar
        );

        /// <summary>
        /// DeviceIoControl, necessário para receber e enviar mensagens
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int DeviceIoControl(
            IntPtr hDevice, // Dispositivo
            uint dwIoControlCode, // Control
            StringBuilder lpInBuffer, // Buffer
            int nInBufferSize, // BufferSize
            StringBuilder lpOutBuffer, // Outbuffer
            Int32 nOutBufferSize, // OutbufferSize
            ref Int32 lpBytesReturned, // Retorno
            IntPtr lpOverlapped //
        );

        // Definições, necessárias
        internal const uint FILE_DEVICE_UNKNOWN = 0x00000022;
        internal const uint FILE_ANY_ACCESS = 0;
        internal const uint METHOD_BUFFERED = 0;
        private const int GENERIC_WRITE = 0x40000000;
        private const int GENERIC_READ = unchecked((int)0x80000000);
        private const int FILE_SHARE_READ = 1;
        private const int FILE_SHARE_WRITE = 2;
        private const int OPEN_EXISTING = 3;
        private const int IOCTL_DISK_GET_DRIVE_LAYOUT_EX = unchecked((int)0x00070050);
        private const int ERROR_INSUFFICIENT_BUFFER = 122;

        /// <summary>
        /// CTL_CODE, necessário para o driver saber se queremos deletar arquivos ou
        /// Outras operações
        /// </summary>
        public static uint CTL_CODE(uint DeviceType, uint Function, uint Method, uint Access)
        {
            // Retorne o valor
            return ((DeviceType << 16) | (Access << 14) | (Function << 2) | Method);
        }

    }
}
