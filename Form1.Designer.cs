namespace BullsAndCows
{
    partial class Form1
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
            this.Start = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.Label();
            this.MaskedWord = new System.Windows.Forms.MaskedTextBox();
            this.Lenght = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(122, 43);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Начать игру";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(9, 9);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(255, 34);
            this.Message.TabIndex = 5;
            this.Message.Text = "Введите длину слова";
            // 
            // Check
            // 
            this.Check.Enabled = false;
            this.Check.Location = new System.Drawing.Point(122, 78);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(107, 23);
            this.Check.TabIndex = 4;
            this.Check.Text = "Проверить";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Progress
            // 
            this.Progress.Enabled = false;
            this.Progress.Location = new System.Drawing.Point(9, 111);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(220, 254);
            this.Progress.TabIndex = 4;
            // 
            // MaskedWord
            // 
            this.MaskedWord.Enabled = false;
            this.MaskedWord.Location = new System.Drawing.Point(12, 78);
            this.MaskedWord.Name = "MaskedWord";
            this.MaskedWord.Size = new System.Drawing.Size(63, 20);
            this.MaskedWord.TabIndex = 3;
            this.MaskedWord.ValidatingType = typeof(int);
            this.MaskedWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaskedWordKeyDown);
            // 
            // Lenght
            // 
            this.Lenght.Location = new System.Drawing.Point(12, 46);
            this.Lenght.Mask = "0";
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(18, 20);
            this.Lenght.TabIndex = 1;
            this.Lenght.ValidatingType = typeof(int);
            this.Lenght.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LenghtKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 374);
            this.Controls.Add(this.Lenght);
            this.Controls.Add(this.MaskedWord);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Быки и коровы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label Progress;
        private System.Windows.Forms.MaskedTextBox MaskedWord;
        private System.Windows.Forms.MaskedTextBox Lenght;
    }
}

