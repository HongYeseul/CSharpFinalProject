namespace CSharpFinalProject
{
    partial class calcForm
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
            this.txtFirstNum = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCalc = new System.Windows.Forms.ComboBox();
            this.txtSecondNum = new System.Windows.Forms.NumericUpDown();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondNum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(37, 34);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(59, 21);
            this.txtFirstNum.TabIndex = 0;
            // 
            // comboBoxCalc
            // 
            this.comboBoxCalc.FormattingEnabled = true;
            this.comboBoxCalc.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxCalc.Location = new System.Drawing.Point(103, 34);
            this.comboBoxCalc.Name = "comboBoxCalc";
            this.comboBoxCalc.Size = new System.Drawing.Size(44, 20);
            this.comboBoxCalc.TabIndex = 1;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(153, 34);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(59, 21);
            this.txtSecondNum.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(131, 95);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 21);
            this.txtResult.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(250, 17);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 54);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "계산하기";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // calcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 139);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.comboBoxCalc);
            this.Controls.Add(this.txtFirstNum);
            this.Name = "calcForm";
            this.Text = "calcForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtFirstNum;
        private System.Windows.Forms.ComboBox comboBoxCalc;
        private System.Windows.Forms.NumericUpDown txtSecondNum;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalc;
    }
}