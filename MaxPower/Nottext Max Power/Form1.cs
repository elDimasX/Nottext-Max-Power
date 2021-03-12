///
/// Nottext Max Power - 2021, Desenvolvido por Dimas Pereira
///

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Nottext_Max_Power
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Classe que vai conter as definiçõs de mensagens
        /// </summary>
        public class CtlCodes : Form1
        {
            // Avisa que vai deletar um arquivo
            public static uint DELETE_FILE = Communication.CTL_CODE(
                Communication.FILE_DEVICE_UNKNOWN,
                0x2500,
                Communication.METHOD_BUFFERED,
                Communication.FILE_ANY_ACCESS
            );

            // Avisa que vai criar um arquivo
            public static uint CREATE_FILE = Communication.CTL_CODE(
                Communication.FILE_DEVICE_UNKNOWN,
                0x2505,
                Communication.METHOD_BUFFERED,
                Communication.FILE_ANY_ACCESS
            );

            // Avisa que vai deletar um valor no registro
            public static uint DELETE_REG = Communication.CTL_CODE(
                Communication.FILE_DEVICE_UNKNOWN,
                0x2510,
                Communication.METHOD_BUFFERED,
                Communication.FILE_ANY_ACCESS
            );

            // Avisa que vai criar uma chave no registro
            public static uint CREATE_REG = Communication.CTL_CODE(
                Communication.FILE_DEVICE_UNKNOWN,
                0x2520,
                Communication.METHOD_BUFFERED,
                Communication.FILE_ANY_ACCESS
            );

            // Avisa que vai travar o sistema
            public static uint CRASH_SYSTEM = Communication.CTL_CODE(
                Communication.FILE_DEVICE_UNKNOWN,
                0x2530,
                Communication.METHOD_BUFFERED,
                Communication.FILE_ANY_ACCESS
            );

            // Avisa que é pra negar novos processos
            public static uint DENY_PROCESSES = Communication.CTL_CODE(
                Communication.FILE_DEVICE_UNKNOWN,
                0x2540,
                Communication.METHOD_BUFFERED,
                Communication.FILE_ANY_ACCESS
            );

            // Avisa que é pra deletar uma pasta
            public static uint DELETE_FOLDER = Communication.CTL_CODE(
                Communication.FILE_DEVICE_UNKNOWN,
                0x2550,
                Communication.METHOD_BUFFERED,
                Communication.FILE_ANY_ACCESS
            );

            // Avisa que é pra criar uma pasta
            public static uint CREATE_FOLDER = Communication.CTL_CODE(
                Communication.FILE_DEVICE_UNKNOWN,
                0x2555,
                Communication.METHOD_BUFFERED,
                Communication.FILE_ANY_ACCESS
            );
        }

        /// <summary>
        /// Inicia tudo
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ShadowForm.ApplyShadows(this);

            // Sete um cursor melhor
            DllCursor.SetHandCursor(this);
        }

        /// <summary>
        /// Depois de clicar no botão de deletar arquivo
        /// </summary>
        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            // Queremos deletar um arquivo
            Communication.SendMessage(
                // Local do arquivo
                "\\DosDevices\\" + createOrDeleteFileLocation.Text,

                // Delete o arquivo
                CtlCodes.DELETE_FILE
           );
        }

        /// <summary>
        /// Depois de clicar no botão de criar arquivo
        /// </summary>
        private void createFileButton_Click(object sender, EventArgs e)
        {
            // Queremos criar um arquivo
            Communication.SendMessage(
                // Local do arquivo
                "\\DosDevices\\" + createOrDeleteFileLocation.Text,

                // Crie o arquivo
                CtlCodes.CREATE_FILE
           );
        }

        /// <summary>
        /// Depois de clicar no botão de deletar registro
        /// </summary>
        private void deleteRegButton_Click(object sender, EventArgs e)
        {
            // Queremos deletar um valor no registro
            Communication.SendMessage(
                // Local do registro
                "\\Registry\\" + createOrDeleteRegLocation.Text,

                // Delete o valor no registro
                CtlCodes.DELETE_REG
           );
        }

        /// <summary>
        /// Depois de clicar no botão de criar uma chave valor no registro
        /// </summary>
        private void createRegButton_Click(object sender, EventArgs e)
        {
            // Queremos criar uma nova chave no registro
            Communication.SendMessage(
                // Valor da chave
                "\\Registry\\" + createOrDeleteRegLocation.Text,

                // Negue novos processos
                CtlCodes.CREATE_REG
           );
        }

        /// <summary>
        /// Depois de clicar no botão de travar o sistema
        /// </summary>
        private void crashSystemButton_Click(object sender, EventArgs e)
        {
            // Se o usuário cancelar o messageBox
            if (MessageBox.Show("Are you sure about that? this will crash the computer entirely.", "Application said:", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                // Pare
                return;
            }

            // Queremos travar o sistema
            Communication.SendMessage(
                // Tanto faz
                "TANTO FAZ",

                // Trave o sistema
                CtlCodes.CRASH_SYSTEM
           );
        }

        /// <summary>
        /// Abrir um arquivo para deletar
        /// </summary>
        private void openFileToDelete_Click(object sender, EventArgs e)
        {
            // Novo dialogo
            OpenFileDialog dialog = new OpenFileDialog();

            // Se o usuário selecionar um arquivo
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Altere a textBox
                createOrDeleteFileLocation.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// Negar novo processo aberto
        /// </summary>
        private void denyProcessCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Queremos negar novos processos
            Communication.SendMessage(
                // Tanto faz
                "TANTO FAZ",

                // Negue novos processos
                CtlCodes.DENY_PROCESSES
           );
        }

        /// <summary>
        /// Depois de clicar no botão de criar pasta
        /// </summary>
        private void createFolderButton_Click(object sender, EventArgs e)
        {
            // Queremos criar um arquivo
            Communication.SendMessage(
                // Local da pasta
                "\\DosDevices\\" + createOrDeleteFolderLocation.Text,

                // Crie a pasta
                CtlCodes.CREATE_FOLDER
           );
        }

        /// <summary>
        /// Depois de clicar no botão de deletar pasta
        /// </summary>
        private void deleteFolderButton_Click(object sender, EventArgs e)
        {
            // Queremos criar um arquivo
            Communication.SendMessage(
                // Local da pasta
                "\\DosDevices\\" + createOrDeleteFolderLocation.Text,

                // Crie a pasta
                CtlCodes.DELETE_FOLDER
           );
        }
    }
}
