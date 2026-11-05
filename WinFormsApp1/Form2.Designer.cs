namespace WinFormsApp1
{
    partial class Form2
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
            btnMushRoom = new Button();
            btnBicycle = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMushRoom
            // 
            btnMushRoom.BackColor = SystemColors.ActiveCaptionText;
            btnMushRoom.ForeColor = SystemColors.Control;
            btnMushRoom.Location = new Point(460, 188);
            btnMushRoom.Name = "btnMushRoom";
            btnMushRoom.Size = new Size(146, 58);
            btnMushRoom.TabIndex = 0;
            btnMushRoom.Text = "MushRoom";
            btnMushRoom.UseVisualStyleBackColor = false;
            btnMushRoom.Click += btnMushRoom_Click;
            // 
            // btnBicycle
            // 
            btnBicycle.BackColor = SystemColors.ActiveCaptionText;
            btnBicycle.ForeColor = SystemColors.Control;
            btnBicycle.Location = new Point(115, 188);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(147, 58);
            btnBicycle.TabIndex = 1;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(344, 47);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 2;
            label1.Text = "Choose";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBicycle);
            Controls.Add(btnMushRoom);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMushRoom;
        private Button btnBicycle;
        private Label label1;
    }
}