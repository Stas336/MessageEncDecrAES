namespace MessageEncDecrAES
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
            this.origText = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.encrButton = new System.Windows.Forms.Button();
            this.modText = new System.Windows.Forms.TextBox();
            this.decrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // origText
            // 
            this.origText.Location = new System.Drawing.Point(12, 12);
            this.origText.Multiline = true;
            this.origText.Name = "origText";
            this.origText.Size = new System.Drawing.Size(433, 122);
            this.origText.TabIndex = 0;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(12, 268);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(433, 20);
            this.key.TabIndex = 1;
            // 
            // encrButton
            // 
            this.encrButton.Location = new System.Drawing.Point(12, 294);
            this.encrButton.Name = "encrButton";
            this.encrButton.Size = new System.Drawing.Size(213, 52);
            this.encrButton.TabIndex = 3;
            this.encrButton.Text = "Encrypt";
            this.encrButton.UseVisualStyleBackColor = true;
            this.encrButton.Click += new System.EventHandler(this.encrButton_Click);
            // 
            // modText
            // 
            this.modText.Location = new System.Drawing.Point(12, 140);
            this.modText.Multiline = true;
            this.modText.Name = "modText";
            this.modText.Size = new System.Drawing.Size(433, 122);
            this.modText.TabIndex = 4;
            // 
            // decrButton
            // 
            this.decrButton.Location = new System.Drawing.Point(232, 294);
            this.decrButton.Name = "decrButton";
            this.decrButton.Size = new System.Drawing.Size(213, 52);
            this.decrButton.TabIndex = 5;
            this.decrButton.Text = "Decrypt";
            this.decrButton.UseVisualStyleBackColor = true;
            this.decrButton.Click += new System.EventHandler(this.decrButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 358);
            this.Controls.Add(this.decrButton);
            this.Controls.Add(this.modText);
            this.Controls.Add(this.encrButton);
            this.Controls.Add(this.key);
            this.Controls.Add(this.origText);
            this.Name = "Form1";
            this.Text = "AES Message Encryption/Decryption Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox origText;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button encrButton;
        private System.Windows.Forms.TextBox modText;
        private System.Windows.Forms.Button decrButton;
    }
}

