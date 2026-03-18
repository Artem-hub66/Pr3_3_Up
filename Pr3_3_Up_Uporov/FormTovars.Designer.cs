namespace Pr3_3_Up_Uporov
{
    partial class FormTovars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblUserName = new Label();
            btnLogut = new Button();
            dgvTovars = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTovars).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(233, 245, 255);
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btnLogut);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(964, 40);
            panelTop.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(769, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogut
            // 
            btnLogut.BackColor = Color.FromArgb(67, 97, 238);
            btnLogut.Dock = DockStyle.Right;
            btnLogut.FlatStyle = FlatStyle.Flat;
            btnLogut.Location = new Point(814, 0);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(150, 30);
            btnLogut.TabIndex = 0;
            btnLogut.Text = "Выход";
            btnLogut.UseVisualStyleBackColor = false;
            btnLogut.Click += BtnLogut_Click;
            // 
            // dgvTovars
            // 
            dgvTovars.AllowUserToAddRows = false;
            dgvTovars.AllowUserToDeleteRows = false;
            dgvTovars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTovars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTovars.BackgroundColor = Color.FromArgb(233, 245, 255);
            dgvTovars.BorderStyle = BorderStyle.None;
            dgvTovars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTovars.ColumnHeadersVisible = false;
            dgvTovars.Dock = DockStyle.Fill;
            dgvTovars.Location = new Point(10, 50);
            dgvTovars.MultiSelect = false;
            dgvTovars.Name = "dgvTovars";
            dgvTovars.ReadOnly = true;
            dgvTovars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTovars.Size = new Size(964, 601);
            dgvTovars.TabIndex = 1;
            // 
            // FormTovars
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(984, 661);
            Controls.Add(dgvTovars);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormTovars";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список товаров";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTovars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblUserName;
        private Button btnLogut;
        private DataGridView dgvTovars;
    }
}