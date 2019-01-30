namespace SaveCoil
{
    partial class SaveCoil
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
            this.FileName = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(12, 27);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(51, 13);
            this.FileName.TabIndex = 0;
            this.FileName.Text = "FileName";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(13, 95);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(50, 13);
            this.Message.TabIndex = 1;
            this.Message.Text = "Message";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(289, 43);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 47);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Barcode
            // 
            this.Barcode.Location = new System.Drawing.Point(12, 57);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(271, 20);
            this.Barcode.TabIndex = 3;
            // 
            // SaveCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 128);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.FileName);
            this.Name = "SaveCoil";
            this.Text = "SaveCoil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Barcode;
    }
}

