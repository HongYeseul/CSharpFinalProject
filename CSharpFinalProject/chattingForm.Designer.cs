namespace CSharpFinalProject
{
    partial class chattingForm
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
            this.txtBoxMsg = new System.Windows.Forms.RichTextBox();
            this.txtUserMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxMsg
            // 
            this.txtBoxMsg.Location = new System.Drawing.Point(12, 12);
            this.txtBoxMsg.Name = "txtBoxMsg";
            this.txtBoxMsg.Size = new System.Drawing.Size(331, 269);
            this.txtBoxMsg.TabIndex = 0;
            this.txtBoxMsg.Text = "";
            // 
            // txtUserMsg
            // 
            this.txtUserMsg.Location = new System.Drawing.Point(56, 287);
            this.txtUserMsg.Name = "txtUserMsg";
            this.txtUserMsg.Size = new System.Drawing.Size(206, 21);
            this.txtUserMsg.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(268, 286);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 321);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserMsg);
            this.Controls.Add(this.txtBoxMsg);
            this.Name = "chattingForm";
            this.Text = "chattingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.chattingForm_FormClosed);
            this.Load += new System.EventHandler(this.chattingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxMsg;
        private System.Windows.Forms.TextBox txtUserMsg;
        private System.Windows.Forms.Button btnSend;
    }
}