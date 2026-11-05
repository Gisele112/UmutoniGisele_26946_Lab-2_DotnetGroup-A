namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnClose = new Button();
            btnLogin = new Button();
            txtPassword = new MaskedTextBox();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(323, 39);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 3;
            label1.Text = "Login Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(181, 160);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 4;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(193, 243);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ButtonShadow;
            btnClose.Location = new Point(676, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.AppWorkspace;
            btnLogin.Location = new Point(348, 363);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(348, 243);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 31);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(348, 154);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(278, 31);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(792, 450);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClose;
        private Button btnLogin;
        private MaskedTextBox txtPassword;
        private TextBox txtUserName;
    }
}
