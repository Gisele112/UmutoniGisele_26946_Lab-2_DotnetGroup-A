namespace WinFormsApp1
{
    partial class Form3
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
            btnExitThree = new Button();
            label1 = new Label();
            btnIdentify = new Button();
            btnBack = new Button();
            listMushrooms = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnExitThree
            // 
            btnExitThree.Location = new Point(675, 402);
            btnExitThree.Name = "btnExitThree";
            btnExitThree.Size = new Size(113, 36);
            btnExitThree.TabIndex = 0;
            btnExitThree.Text = "Logout";
            btnExitThree.UseVisualStyleBackColor = true;
            btnExitThree.Click += btnExitThree_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(161, 35);
            label1.Name = "label1";
            label1.Size = new Size(464, 25);
            label1.TabIndex = 1;
            label1.Text = "Think of one of the six mushrooms, then click the button.";
            // 
            // btnIdentify
            // 
            btnIdentify.BackColor = SystemColors.ActiveCaptionText;
            btnIdentify.ForeColor = SystemColors.ButtonFace;
            btnIdentify.Location = new Point(228, 367);
            btnIdentify.Name = "btnIdentify";
            btnIdentify.Size = new Size(273, 48);
            btnIdentify.TabIndex = 2;
            btnIdentify.Text = "Identify my mushroom";
            btnIdentify.UseVisualStyleBackColor = false;
            btnIdentify.Click += btnIdentify_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 48);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // listMushrooms
            // 
            listMushrooms.FormattingEnabled = true;
            listMushrooms.Items.AddRange(new object[] { "Agaric Jaunissant", "Amanite tue-mouche", "Cepe de Bordeaux", "Coprin chevelu", "Girolle", "Pied bleu" });
            listMushrooms.Location = new Point(182, 116);
            listMushrooms.Name = "listMushrooms";
            listMushrooms.Size = new Size(348, 204);
            listMushrooms.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Location = new Point(268, 88);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 5;
            label2.Text = "The six mushrooms:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listMushrooms);
            Controls.Add(btnBack);
            Controls.Add(btnIdentify);
            Controls.Add(label1);
            Controls.Add(btnExitThree);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExitThree;
        private Label label1;
        private Button btnIdentify;
        private Button btnBack;
        private ListBox listMushrooms;
        private Label label2;
    }
}