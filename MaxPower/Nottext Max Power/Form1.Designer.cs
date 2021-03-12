
namespace Nottext_Max_Power
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.minimize = new Guna.UI.WinForms.GunaControlBox();
            this.close = new Guna.UI.WinForms.GunaControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.fileTab = new System.Windows.Forms.TabPage();
            this.deleteFolderButton = new Guna.UI.WinForms.GunaButton();
            this.createFolderButton = new Guna.UI.WinForms.GunaButton();
            this.label13 = new System.Windows.Forms.Label();
            this.createOrDeleteFolderLocation = new Guna.UI.WinForms.GunaTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteFileButton = new Guna.UI.WinForms.GunaButton();
            this.openFileToDelete = new Guna.UI.WinForms.GunaButton();
            this.createFileButton = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.createOrDeleteFileLocation = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regTab = new System.Windows.Forms.TabPage();
            this.createRegButton = new Guna.UI.WinForms.GunaButton();
            this.deleteRegButton = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.createOrDeleteRegLocation = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SystemTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.denyProcessCheckbox = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.crashSystemButton = new Guna.UI.WinForms.GunaButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.drag1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drag2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drag3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.fileTab.SuspendLayout();
            this.regTab.SuspendLayout();
            this.SystemTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.header.Controls.Add(this.subtitle);
            this.header.Controls.Add(this.title);
            this.header.Controls.Add(this.minimize);
            this.header.Controls.Add(this.close);
            this.header.Controls.Add(this.pictureBox1);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(3, 2);
            this.header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(622, 71);
            this.header.TabIndex = 0;
            // 
            // subtitle
            // 
            this.subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subtitle.AutoSize = true;
            this.subtitle.Location = new System.Drawing.Point(442, 50);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(176, 20);
            this.subtitle.TabIndex = 8;
            this.subtitle.Text = "© 2021 Nottext Security";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(51, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(247, 70);
            this.title.TabIndex = 4;
            this.title.Text = "Nottext - Max Power / Anti-Rootkit";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.Animated = true;
            this.minimize.AnimationHoverSpeed = 0.07F;
            this.minimize.AnimationSpeed = 0.03F;
            this.minimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.minimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.minimize.IconSize = 15F;
            this.minimize.Location = new System.Drawing.Point(538, 0);
            this.minimize.Name = "minimize";
            this.minimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.minimize.OnHoverIconColor = System.Drawing.Color.White;
            this.minimize.OnPressedColor = System.Drawing.Color.Black;
            this.minimize.Size = new System.Drawing.Size(45, 29);
            this.minimize.TabIndex = 10;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Animated = true;
            this.close.AnimationHoverSpeed = 0.07F;
            this.close.AnimationSpeed = 0.03F;
            this.close.IconColor = System.Drawing.Color.WhiteSmoke;
            this.close.IconSize = 15F;
            this.close.Location = new System.Drawing.Point(577, 0);
            this.close.Name = "close";
            this.close.OnHoverBackColor = System.Drawing.Color.Crimson;
            this.close.OnHoverIconColor = System.Drawing.Color.White;
            this.close.OnPressedColor = System.Drawing.Color.Black;
            this.close.Size = new System.Drawing.Size(45, 29);
            this.close.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.fileTab);
            this.TabControl.Controls.Add(this.regTab);
            this.TabControl.Controls.Add(this.SystemTab);
            this.TabControl.Location = new System.Drawing.Point(3, 74);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(622, 407);
            this.TabControl.TabIndex = 1;
            // 
            // fileTab
            // 
            this.fileTab.AutoScroll = true;
            this.fileTab.BackColor = System.Drawing.Color.White;
            this.fileTab.Controls.Add(this.deleteFolderButton);
            this.fileTab.Controls.Add(this.createFolderButton);
            this.fileTab.Controls.Add(this.label13);
            this.fileTab.Controls.Add(this.createOrDeleteFolderLocation);
            this.fileTab.Controls.Add(this.label14);
            this.fileTab.Controls.Add(this.deleteFileButton);
            this.fileTab.Controls.Add(this.openFileToDelete);
            this.fileTab.Controls.Add(this.createFileButton);
            this.fileTab.Controls.Add(this.label2);
            this.fileTab.Controls.Add(this.createOrDeleteFileLocation);
            this.fileTab.Controls.Add(this.label1);
            this.fileTab.Location = new System.Drawing.Point(4, 29);
            this.fileTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileTab.Name = "fileTab";
            this.fileTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fileTab.Size = new System.Drawing.Size(614, 374);
            this.fileTab.TabIndex = 0;
            this.fileTab.Text = "Files";
            // 
            // deleteFolderButton
            // 
            this.deleteFolderButton.Animated = true;
            this.deleteFolderButton.AnimationHoverSpeed = 0.07F;
            this.deleteFolderButton.AnimationSpeed = 0.03F;
            this.deleteFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteFolderButton.BaseColor = System.Drawing.Color.White;
            this.deleteFolderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.deleteFolderButton.BorderSize = 2;
            this.deleteFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFolderButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteFolderButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.deleteFolderButton.Image = null;
            this.deleteFolderButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteFolderButton.Location = new System.Drawing.Point(214, 204);
            this.deleteFolderButton.Name = "deleteFolderButton";
            this.deleteFolderButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.deleteFolderButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.deleteFolderButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteFolderButton.OnHoverImage = null;
            this.deleteFolderButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteFolderButton.Radius = 5;
            this.deleteFolderButton.Size = new System.Drawing.Size(160, 30);
            this.deleteFolderButton.TabIndex = 29;
            this.deleteFolderButton.Text = "DELETE FOLDER";
            this.deleteFolderButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteFolderButton.Click += new System.EventHandler(this.deleteFolderButton_Click);
            // 
            // createFolderButton
            // 
            this.createFolderButton.Animated = true;
            this.createFolderButton.AnimationHoverSpeed = 0.07F;
            this.createFolderButton.AnimationSpeed = 0.03F;
            this.createFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.createFolderButton.BaseColor = System.Drawing.Color.White;
            this.createFolderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createFolderButton.BorderSize = 2;
            this.createFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createFolderButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createFolderButton.FocusedColor = System.Drawing.Color.Empty;
            this.createFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createFolderButton.Image = null;
            this.createFolderButton.ImageSize = new System.Drawing.Size(20, 20);
            this.createFolderButton.Location = new System.Drawing.Point(19, 204);
            this.createFolderButton.Name = "createFolderButton";
            this.createFolderButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.createFolderButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.createFolderButton.OnHoverForeColor = System.Drawing.Color.White;
            this.createFolderButton.OnHoverImage = null;
            this.createFolderButton.OnPressedColor = System.Drawing.Color.Black;
            this.createFolderButton.Radius = 5;
            this.createFolderButton.Size = new System.Drawing.Size(160, 30);
            this.createFolderButton.TabIndex = 25;
            this.createFolderButton.Text = "CREATE FOLDER";
            this.createFolderButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createFolderButton.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(400, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Tell the kernel that you want to create or delete a folder.";
            // 
            // createOrDeleteFolderLocation
            // 
            this.createOrDeleteFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createOrDeleteFolderLocation.BaseColor = System.Drawing.Color.White;
            this.createOrDeleteFolderLocation.BorderColor = System.Drawing.Color.Silver;
            this.createOrDeleteFolderLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createOrDeleteFolderLocation.FocusedBaseColor = System.Drawing.Color.White;
            this.createOrDeleteFolderLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createOrDeleteFolderLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.createOrDeleteFolderLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createOrDeleteFolderLocation.Location = new System.Drawing.Point(166, 148);
            this.createOrDeleteFolderLocation.MaxLength = 0;
            this.createOrDeleteFolderLocation.Name = "createOrDeleteFolderLocation";
            this.createOrDeleteFolderLocation.PasswordChar = '\0';
            this.createOrDeleteFolderLocation.Size = new System.Drawing.Size(362, 30);
            this.createOrDeleteFolderLocation.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Directory Create:";
            // 
            // deleteFileButton
            // 
            this.deleteFileButton.Animated = true;
            this.deleteFileButton.AnimationHoverSpeed = 0.07F;
            this.deleteFileButton.AnimationSpeed = 0.03F;
            this.deleteFileButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteFileButton.BaseColor = System.Drawing.Color.White;
            this.deleteFileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.deleteFileButton.BorderSize = 2;
            this.deleteFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFileButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteFileButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.deleteFileButton.Image = null;
            this.deleteFileButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteFileButton.Location = new System.Drawing.Point(180, 89);
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.deleteFileButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.deleteFileButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteFileButton.OnHoverImage = null;
            this.deleteFileButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteFileButton.Radius = 5;
            this.deleteFileButton.Size = new System.Drawing.Size(130, 30);
            this.deleteFileButton.TabIndex = 21;
            this.deleteFileButton.Text = "DELETE FILE";
            this.deleteFileButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // openFileToDelete
            // 
            this.openFileToDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileToDelete.AnimationHoverSpeed = 0.07F;
            this.openFileToDelete.AnimationSpeed = 0.03F;
            this.openFileToDelete.BackColor = System.Drawing.Color.Transparent;
            this.openFileToDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.openFileToDelete.BorderColor = System.Drawing.Color.Black;
            this.openFileToDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileToDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.openFileToDelete.FocusedColor = System.Drawing.Color.Empty;
            this.openFileToDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.openFileToDelete.ForeColor = System.Drawing.Color.White;
            this.openFileToDelete.Image = null;
            this.openFileToDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.openFileToDelete.Location = new System.Drawing.Point(535, 33);
            this.openFileToDelete.Name = "openFileToDelete";
            this.openFileToDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.openFileToDelete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.openFileToDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.openFileToDelete.OnHoverImage = null;
            this.openFileToDelete.OnPressedColor = System.Drawing.Color.Black;
            this.openFileToDelete.Radius = 5;
            this.openFileToDelete.Size = new System.Drawing.Size(44, 30);
            this.openFileToDelete.TabIndex = 19;
            this.openFileToDelete.Text = "...";
            this.openFileToDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.openFileToDelete.Click += new System.EventHandler(this.openFileToDelete_Click);
            // 
            // createFileButton
            // 
            this.createFileButton.Animated = true;
            this.createFileButton.AnimationHoverSpeed = 0.07F;
            this.createFileButton.AnimationSpeed = 0.03F;
            this.createFileButton.BackColor = System.Drawing.Color.Transparent;
            this.createFileButton.BaseColor = System.Drawing.Color.White;
            this.createFileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createFileButton.BorderSize = 2;
            this.createFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createFileButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createFileButton.FocusedColor = System.Drawing.Color.Empty;
            this.createFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createFileButton.Image = null;
            this.createFileButton.ImageSize = new System.Drawing.Size(20, 20);
            this.createFileButton.Location = new System.Drawing.Point(19, 89);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.createFileButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.createFileButton.OnHoverForeColor = System.Drawing.Color.White;
            this.createFileButton.OnHoverImage = null;
            this.createFileButton.OnPressedColor = System.Drawing.Color.Black;
            this.createFileButton.Radius = 5;
            this.createFileButton.Size = new System.Drawing.Size(130, 30);
            this.createFileButton.TabIndex = 16;
            this.createFileButton.Text = "CREATE FILE";
            this.createFileButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tell the kernel that you want to create or delete a file.";
            // 
            // createOrDeleteFileLocation
            // 
            this.createOrDeleteFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createOrDeleteFileLocation.BaseColor = System.Drawing.Color.White;
            this.createOrDeleteFileLocation.BorderColor = System.Drawing.Color.Silver;
            this.createOrDeleteFileLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createOrDeleteFileLocation.FocusedBaseColor = System.Drawing.Color.White;
            this.createOrDeleteFileLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createOrDeleteFileLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.createOrDeleteFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createOrDeleteFileLocation.Location = new System.Drawing.Point(123, 33);
            this.createOrDeleteFileLocation.MaxLength = 0;
            this.createOrDeleteFileLocation.Name = "createOrDeleteFileLocation";
            this.createOrDeleteFileLocation.PasswordChar = '\0';
            this.createOrDeleteFileLocation.Size = new System.Drawing.Size(406, 30);
            this.createOrDeleteFileLocation.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Create:";
            // 
            // regTab
            // 
            this.regTab.Controls.Add(this.createRegButton);
            this.regTab.Controls.Add(this.deleteRegButton);
            this.regTab.Controls.Add(this.label5);
            this.regTab.Controls.Add(this.createOrDeleteRegLocation);
            this.regTab.Controls.Add(this.label6);
            this.regTab.Location = new System.Drawing.Point(4, 29);
            this.regTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regTab.Name = "regTab";
            this.regTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regTab.Size = new System.Drawing.Size(614, 374);
            this.regTab.TabIndex = 1;
            this.regTab.Text = "Registry";
            this.regTab.UseVisualStyleBackColor = true;
            // 
            // createRegButton
            // 
            this.createRegButton.Animated = true;
            this.createRegButton.AnimationHoverSpeed = 0.07F;
            this.createRegButton.AnimationSpeed = 0.03F;
            this.createRegButton.BackColor = System.Drawing.Color.Transparent;
            this.createRegButton.BaseColor = System.Drawing.Color.White;
            this.createRegButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createRegButton.BorderSize = 2;
            this.createRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createRegButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createRegButton.FocusedColor = System.Drawing.Color.Empty;
            this.createRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createRegButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createRegButton.Image = null;
            this.createRegButton.ImageSize = new System.Drawing.Size(20, 20);
            this.createRegButton.Location = new System.Drawing.Point(20, 113);
            this.createRegButton.Name = "createRegButton";
            this.createRegButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.createRegButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.createRegButton.OnHoverForeColor = System.Drawing.Color.White;
            this.createRegButton.OnHoverImage = null;
            this.createRegButton.OnPressedColor = System.Drawing.Color.Black;
            this.createRegButton.Radius = 5;
            this.createRegButton.Size = new System.Drawing.Size(130, 30);
            this.createRegButton.TabIndex = 25;
            this.createRegButton.Text = "CREATE REG";
            this.createRegButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createRegButton.Click += new System.EventHandler(this.createRegButton_Click);
            // 
            // deleteRegButton
            // 
            this.deleteRegButton.Animated = true;
            this.deleteRegButton.AnimationHoverSpeed = 0.07F;
            this.deleteRegButton.AnimationSpeed = 0.03F;
            this.deleteRegButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteRegButton.BaseColor = System.Drawing.Color.White;
            this.deleteRegButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.deleteRegButton.BorderSize = 2;
            this.deleteRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRegButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteRegButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteRegButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.deleteRegButton.Image = null;
            this.deleteRegButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteRegButton.Location = new System.Drawing.Point(204, 113);
            this.deleteRegButton.Name = "deleteRegButton";
            this.deleteRegButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.deleteRegButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.deleteRegButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteRegButton.OnHoverImage = null;
            this.deleteRegButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteRegButton.Radius = 5;
            this.deleteRegButton.Size = new System.Drawing.Size(130, 30);
            this.deleteRegButton.TabIndex = 20;
            this.deleteRegButton.Text = "DELETE REG";
            this.deleteRegButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteRegButton.Click += new System.EventHandler(this.deleteRegButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 44);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tell the kernel that you want to delete or create a folder in the registry (delet" +
    "e it doesn\'t work if there are other subfolders). Exemple: \'Machine\\Folder\'";
            // 
            // createOrDeleteRegLocation
            // 
            this.createOrDeleteRegLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createOrDeleteRegLocation.BaseColor = System.Drawing.Color.White;
            this.createOrDeleteRegLocation.BorderColor = System.Drawing.Color.Silver;
            this.createOrDeleteRegLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createOrDeleteRegLocation.FocusedBaseColor = System.Drawing.Color.White;
            this.createOrDeleteRegLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.createOrDeleteRegLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.createOrDeleteRegLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createOrDeleteRegLocation.Location = new System.Drawing.Point(155, 33);
            this.createOrDeleteRegLocation.MaxLength = 0;
            this.createOrDeleteRegLocation.Name = "createOrDeleteRegLocation";
            this.createOrDeleteRegLocation.PasswordChar = '\0';
            this.createOrDeleteRegLocation.Size = new System.Drawing.Size(431, 30);
            this.createOrDeleteRegLocation.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Registry delete:";
            // 
            // SystemTab
            // 
            this.SystemTab.Controls.Add(this.label10);
            this.SystemTab.Controls.Add(this.label8);
            this.SystemTab.Controls.Add(this.denyProcessCheckbox);
            this.SystemTab.Controls.Add(this.crashSystemButton);
            this.SystemTab.Controls.Add(this.label9);
            this.SystemTab.Controls.Add(this.label7);
            this.SystemTab.Location = new System.Drawing.Point(4, 29);
            this.SystemTab.Name = "SystemTab";
            this.SystemTab.Padding = new System.Windows.Forms.Padding(3);
            this.SystemTab.Size = new System.Drawing.Size(614, 374);
            this.SystemTab.TabIndex = 2;
            this.SystemTab.Text = "System";
            this.SystemTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(299, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Block new processes from being opened.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Deny new process open";
            // 
            // denyProcessCheckbox
            // 
            this.denyProcessCheckbox.BaseColor = System.Drawing.SystemColors.Control;
            this.denyProcessCheckbox.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.denyProcessCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.denyProcessCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.denyProcessCheckbox.FillColor = System.Drawing.Color.White;
            this.denyProcessCheckbox.Location = new System.Drawing.Point(222, 148);
            this.denyProcessCheckbox.Name = "denyProcessCheckbox";
            this.denyProcessCheckbox.Size = new System.Drawing.Size(38, 20);
            this.denyProcessCheckbox.TabIndex = 22;
            this.denyProcessCheckbox.CheckedChanged += new System.EventHandler(this.denyProcessCheckbox_CheckedChanged);
            // 
            // crashSystemButton
            // 
            this.crashSystemButton.Animated = true;
            this.crashSystemButton.AnimationHoverSpeed = 0.07F;
            this.crashSystemButton.AnimationSpeed = 0.03F;
            this.crashSystemButton.BackColor = System.Drawing.Color.Transparent;
            this.crashSystemButton.BaseColor = System.Drawing.Color.White;
            this.crashSystemButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.crashSystemButton.BorderSize = 2;
            this.crashSystemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crashSystemButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.crashSystemButton.FocusedColor = System.Drawing.Color.Empty;
            this.crashSystemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.crashSystemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.crashSystemButton.Image = null;
            this.crashSystemButton.ImageSize = new System.Drawing.Size(20, 20);
            this.crashSystemButton.Location = new System.Drawing.Point(19, 80);
            this.crashSystemButton.Name = "crashSystemButton";
            this.crashSystemButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.crashSystemButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.crashSystemButton.OnHoverForeColor = System.Drawing.Color.White;
            this.crashSystemButton.OnHoverImage = null;
            this.crashSystemButton.OnPressedColor = System.Drawing.Color.Black;
            this.crashSystemButton.Radius = 5;
            this.crashSystemButton.Size = new System.Drawing.Size(158, 30);
            this.crashSystemButton.TabIndex = 21;
            this.crashSystemButton.Text = "CRASH SYSTEM!";
            this.crashSystemButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.crashSystemButton.Click += new System.EventHandler(this.crashSystemButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(505, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Do you want to lock the system completely? just click the button below.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Crash system";
            // 
            // drag1
            // 
            this.drag1.TargetControl = this.header;
            // 
            // drag2
            // 
            this.drag2.TargetControl = this.title;
            // 
            // drag3
            // 
            this.drag3.TargetControl = this.subtitle;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(627, 483);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nottext Max Power - USE WITH CAUTION!";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.fileTab.ResumeLayout(false);
            this.fileTab.PerformLayout();
            this.regTab.ResumeLayout(false);
            this.regTab.PerformLayout();
            this.SystemTab.ResumeLayout(false);
            this.SystemTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage regTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private Guna.UI.WinForms.GunaControlBox minimize;
        private Guna.UI.WinForms.GunaControlBox close;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox createOrDeleteFileLocation;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton createFileButton;
        private Guna.UI.WinForms.GunaButton deleteFileButton;
        private Guna.UI.WinForms.GunaButton openFileToDelete;
        private Guna.UI.WinForms.GunaButton deleteRegButton;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox createOrDeleteRegLocation;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaDragControl drag1;
        private Guna.UI.WinForms.GunaDragControl drag2;
        private Guna.UI.WinForms.GunaDragControl drag3;
        private System.Windows.Forms.TabPage SystemTab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton crashSystemButton;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaGoogleSwitch denyProcessCheckbox;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton createRegButton;
        private Guna.UI.WinForms.GunaButton createFolderButton;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaTextBox createOrDeleteFolderLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage fileTab;
        private Guna.UI.WinForms.GunaButton deleteFolderButton;
    }
}

