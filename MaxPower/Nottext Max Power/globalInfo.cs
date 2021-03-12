///
/// Vai conter os titulos e mensagens para ajudar o usuário
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nottext_Max_Power
{
    class globalInfo
    {
        /// <summary>
        /// Registro
        /// </summary>
        public class Reg : globalInfo
        {
            /// <summary>
            /// Delear
            /// </summary>
            public class Delete : Reg
            {
                // Titlo
                public static string Title = "About Reg Delete Tab";

                // Mensagem ensinando a usar
                public static string Msg =

                "This function is used to delete folders in regedit, it only works if it does not contain subfolders.\r\n\r\n" +

                "How to use:\r\n" +

                "HKEY_LOCAL_MACHINE = \\Machine\\ \r\n" +
                "HKEY_USERS = \\User\\ \r\n" +
                "HKEY_CLASSES_ROOT = No kernel-mode equivalent\r\n" +
                "HKEY_CURRENT_USER = No simple kernel-mode equivalent";
            }
        }

        /// <summary>
        /// Arquivo
        /// </summary>
        public class File : globalInfo
        {
            /// <summary>
            /// Delear
            /// </summary>
            public class Delete : File
            {
                // Titlo
                public static string Title = "About File Delete Tab";

                // Mensagem ensinando a usar
                public static string Msg =

                "This function forces the deletion of a file.\r\n\r\n" +

                "How to use:\r\n" +

                "Enter the file name, and click 'Delete'.\r\n";
            }

            /// <summary>
            /// Criar
            /// </summary>
            public class Create : File
            {
                // Titlo
                public static string Title = "About File Create Tab";

                // Mensagem ensinando a usar
                public static string Msg =

                "This function creates a file.\r\n\r\n" +

                "How to use:\r\n" +

                "Enter the file name, and click 'Create'.\r\n";
            }
        }

    }
}
