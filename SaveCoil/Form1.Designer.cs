namespace SaveCoil
{
    partial class BarcodeCapture
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
            this.Message1 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.TodayCoil = new System.Windows.Forms.Label();
            this.TodayCoil2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message1
            // 
            this.Message1.AutoSize = true;
            this.Message1.Location = new System.Drawing.Point(12, 9);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(107, 13);
            this.Message1.TabIndex = 0;
            this.Message1.Text = "Please scan barcode";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(12, 48);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(50, 13);
            this.Message.TabIndex = 1;
            this.Message.Text = "Message";
            // 
            // Barcode
            // 
            this.Barcode.Location = new System.Drawing.Point(12, 25);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(271, 20);
            this.Barcode.TabIndex = 3;
            this.Barcode.TextChanged += new System.EventHandler(this.Barcode_TextChanged);
            // 
            // TodayCoil
            // 
            this.TodayCoil.AutoSize = true;
            this.TodayCoil.Location = new System.Drawing.Point(12, 74);
            this.TodayCoil.Name = "TodayCoil";
            this.TodayCoil.Size = new System.Drawing.Size(64, 13);
            this.TodayCoil.TabIndex = 4;
            this.TodayCoil.Text = "Today\'s Coil";
            // 
            // TodayCoil2
            // 
            this.TodayCoil2.AutoSize = true;
            this.TodayCoil2.Location = new System.Drawing.Point(339, 9);
            this.TodayCoil2.Name = "TodayCoil2";
            this.TodayCoil2.Size = new System.Drawing.Size(0, 13);
            this.TodayCoil2.TabIndex = 5;
            // 
            // BarcodeCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 291);
            this.Controls.Add(this.TodayCoil2);
            this.Controls.Add(this.TodayCoil);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Message1);
            this.Name = "BarcodeCapture";
            this.Text = "Barcode Capture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message1;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox Barcode;
        private System.Windows.Forms.Label TodayCoil;
        private System.Windows.Forms.Label TodayCoil2;
    }
}

