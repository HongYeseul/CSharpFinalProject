namespace CSharpFinalProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClickFriend = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.radioBtnNick = new System.Windows.Forms.RadioButton();
            this.radioBtnAge = new System.Windows.Forms.RadioButton();
            this.radioBtnBF = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.labelTest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 39);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(307, 147);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(6, 192);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "글쓰기";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnClickFriend
            // 
            this.btnClickFriend.Location = new System.Drawing.Point(168, 192);
            this.btnClickFriend.Name = "btnClickFriend";
            this.btnClickFriend.Size = new System.Drawing.Size(75, 23);
            this.btnClickFriend.TabIndex = 4;
            this.btnClickFriend.Text = "찌르기";
            this.btnClickFriend.UseVisualStyleBackColor = true;
            this.btnClickFriend.Click += new System.EventHandler(this.btnClickFriend_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.Location = new System.Drawing.Point(249, 192);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(75, 23);
            this.btnFriends.TabIndex = 5;
            this.btnFriends.Text = "친구찾기";
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "님 안녕하세요.";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(244, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnBF);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioBtnAge);
            this.groupBox1.Controls.Add(this.radioBtnNick);
            this.groupBox1.Location = new System.Drawing.Point(6, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 110);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "친구리스트";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 12;
            this.listBoxFriends.Location = new System.Drawing.Point(23, 348);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(275, 208);
            this.listBoxFriends.TabIndex = 0;
            // 
            // radioBtnNick
            // 
            this.radioBtnNick.AutoSize = true;
            this.radioBtnNick.Location = new System.Drawing.Point(17, 20);
            this.radioBtnNick.Name = "radioBtnNick";
            this.radioBtnNick.Size = new System.Drawing.Size(169, 16);
            this.radioBtnNick.TabIndex = 1;
            this.radioBtnNick.TabStop = true;
            this.radioBtnNick.Text = "닉네임 정렬하기(오름차순)";
            this.radioBtnNick.UseVisualStyleBackColor = true;
            this.radioBtnNick.CheckedChanged += new System.EventHandler(this.radioBtnNick_CheckedChanged);
            // 
            // radioBtnAge
            // 
            this.radioBtnAge.AutoSize = true;
            this.radioBtnAge.Location = new System.Drawing.Point(17, 42);
            this.radioBtnAge.Name = "radioBtnAge";
            this.radioBtnAge.Size = new System.Drawing.Size(197, 16);
            this.radioBtnAge.TabIndex = 2;
            this.radioBtnAge.TabStop = true;
            this.radioBtnAge.Text = "나이 순으로 정렬하기(오름차순)";
            this.radioBtnAge.UseVisualStyleBackColor = true;
            this.radioBtnAge.CheckedChanged += new System.EventHandler(this.radioBtnAge_CheckedChanged);
            // 
            // radioBtnBF
            // 
            this.radioBtnBF.AutoSize = true;
            this.radioBtnBF.Location = new System.Drawing.Point(17, 64);
            this.radioBtnBF.Name = "radioBtnBF";
            this.radioBtnBF.Size = new System.Drawing.Size(99, 16);
            this.radioBtnBF.TabIndex = 4;
            this.radioBtnBF.TabStop = true;
            this.radioBtnBF.Text = "친한친구 찾기";
            this.radioBtnBF.UseVisualStyleBackColor = true;
            this.radioBtnBF.CheckedChanged += new System.EventHandler(this.radioBtnBF_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(17, 86);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(92, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(339, 348);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(155, 12);
            this.labelTest.TabIndex = 9;
            this.labelTest.Text = "누구님을 3번 찌르셨습니다.";
            this.labelTest.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 585);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.btnClickFriend);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "SNS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClickFriend;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.RadioButton radioBtnBF;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioBtnAge;
        private System.Windows.Forms.RadioButton radioBtnNick;
        private System.Windows.Forms.Label labelTest;
    }
}

