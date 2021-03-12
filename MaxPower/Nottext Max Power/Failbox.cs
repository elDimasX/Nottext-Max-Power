using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nottext_Max_Power
{
    public partial class Failbox : Form
    {
        public Failbox(string msg, bool sucess)
        {
            InitializeComponent();
            ShadowForm.ApplyShadows(this);

            // Sete um cursor melhor
            DllCursor.SetHandCursor(this);

            label1.Text = msg;

            if (sucess == false)
            {
                pictureBox1.BackgroundImage = Properties.Resources.alert;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
