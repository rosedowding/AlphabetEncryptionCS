namespace AlphabetEncryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Explanation = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(260, 58);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(304, 37);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Alphabet Encryption";
            // 
            // Explanation
            // 
            this.Explanation.AutoSize = true;
            this.Explanation.Location = new System.Drawing.Point(50, 113);
            this.Explanation.Name = "Explanation";
            this.Explanation.Size = new System.Drawing.Size(726, 78);
            this.Explanation.TabIndex = 1;
            this.Explanation.Text = resources.GetString("Explanation.Text");
            this.Explanation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(267, 214);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(297, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // encryptionButton
            // 
            this.encryptionButton.Location = new System.Drawing.Point(378, 250);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.encryptionButton.Size = new System.Drawing.Size(75, 23);
            this.encryptionButton.TabIndex = 3;
            this.encryptionButton.Text = "Encrypt";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.Explanation);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Alphabet Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Explanation;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button encryptionButton;
    }
}

