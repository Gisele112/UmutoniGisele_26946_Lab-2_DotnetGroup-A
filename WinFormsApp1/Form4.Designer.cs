namespace WinFormsApp1
{
    partial class Form4
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
            btnLogout = new Button();
            label1 = new Label();
            label2 = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnCaculate = new Button();
            btnBack = new Button();
            label3 = new Label();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(676, 394);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 32);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnExitFour_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(83, 110);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter Starting hour :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(89, 188);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 2;
            label2.Text = "Enter Ending hour :";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(315, 110);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(238, 31);
            txtStart.TabIndex = 3;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(315, 188);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(238, 31);
            txtEnd.TabIndex = 4;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(237, 347);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(243, 60);
            btnCaculate.TabIndex = 5;
            btnCaculate.Text = "Calculate";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 38);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(149, 260);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 7;
            label3.Text = "Total (RWF):";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(315, 260);
            txtTotal.Name = "txtTotal";
            txtTotal.ScrollBars = ScrollBars.Horizontal;
            txtTotal.Size = new Size(238, 31);
            txtTotal.TabIndex = 8;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnCaculate);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Label label1;
        private Label label2;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnCaculate;
        private Button btnBack;
        private Label label3;
        private TextBox txtTotal;
    }
}