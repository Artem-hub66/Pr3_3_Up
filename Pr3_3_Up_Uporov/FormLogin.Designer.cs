namespace Pr3_3_Up_Uporov
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            pnMain = new Panel();
            lbLogin = new Label();
            txtlogin = new TextBox();
            lbPass = new Label();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnGuest = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.icon;
            pbLogo.Location = new Point(142, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(233, 245, 255);
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(txtPass);
            pnMain.Controls.Add(lbPass);
            pnMain.Controls.Add(txtlogin);
            pnMain.Controls.Add(lbLogin);
            pnMain.Location = new Point(28, 118);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(329, 219);
            pnMain.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(138, 15);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(52, 19);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Логин";
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(39, 40);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(250, 26);
            txtlogin.TabIndex = 1;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(135, 72);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(58, 19);
            lbPass.TabIndex = 2;
            lbPass.Text = "Пароль";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(39, 97);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(250, 26);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 97, 238);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(89, 129);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(67, 97, 238);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(89, 165);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 30);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(384, 361);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnMain;
        private Label lbPass;
        private TextBox txtlogin;
        private Label lbLogin;
        private Button btnLogin;
        private TextBox txtPass;
        private Button btnGuest;
    }
}
