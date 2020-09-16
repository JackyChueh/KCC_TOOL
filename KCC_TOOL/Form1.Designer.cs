namespace KCC_TOOL
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.txtMAIL_PORT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMAIL_PASSWORD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAIL_ACCOUNT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMAIL_SERVER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtMAIL_SUBJECT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMAIL_TO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMAIL_FROM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtMAIL_BODY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOUTPUT = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatabase);
            this.tabControl1.Controls.Add(this.tabEmail);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.textBox6);
            this.tabDatabase.Controls.Add(this.textBox5);
            this.tabDatabase.Controls.Add(this.label5);
            this.tabDatabase.Controls.Add(this.label6);
            this.tabDatabase.Controls.Add(this.textBox7);
            this.tabDatabase.Controls.Add(this.label7);
            this.tabDatabase.Controls.Add(this.textBox8);
            this.tabDatabase.Controls.Add(this.label8);
            this.tabDatabase.Controls.Add(this.button1);
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(976, 354);
            this.tabDatabase.TabIndex = 0;
            this.tabDatabase.Text = "資料庫";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(282, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 22);
            this.textBox5.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "PORT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "密碼";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(90, 34);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(146, 22);
            this.textBox7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "帳號";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(90, 6);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(146, 22);
            this.textBox8.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "SMTP Server";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "執行";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabEmail
            // 
            this.tabEmail.Controls.Add(this.txtMAIL_BODY);
            this.tabEmail.Controls.Add(this.label12);
            this.tabEmail.Controls.Add(this.txtMAIL_SUBJECT);
            this.tabEmail.Controls.Add(this.label11);
            this.tabEmail.Controls.Add(this.txtMAIL_TO);
            this.tabEmail.Controls.Add(this.label10);
            this.tabEmail.Controls.Add(this.txtMAIL_FROM);
            this.tabEmail.Controls.Add(this.label9);
            this.tabEmail.Controls.Add(this.txtMAIL_PORT);
            this.tabEmail.Controls.Add(this.label4);
            this.tabEmail.Controls.Add(this.txtMAIL_PASSWORD);
            this.tabEmail.Controls.Add(this.label3);
            this.tabEmail.Controls.Add(this.txtMAIL_ACCOUNT);
            this.tabEmail.Controls.Add(this.label2);
            this.tabEmail.Controls.Add(this.txtMAIL_SERVER);
            this.tabEmail.Controls.Add(this.label1);
            this.tabEmail.Controls.Add(this.btnEmail);
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(976, 354);
            this.tabEmail.TabIndex = 1;
            this.tabEmail.Text = "電子郵件";
            this.tabEmail.UseVisualStyleBackColor = true;
            // 
            // txtMAIL_PORT
            // 
            this.txtMAIL_PORT.Location = new System.Drawing.Point(271, 6);
            this.txtMAIL_PORT.Name = "txtMAIL_PORT";
            this.txtMAIL_PORT.Size = new System.Drawing.Size(146, 22);
            this.txtMAIL_PORT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "PORT";
            // 
            // txtMAIL_PASSWORD
            // 
            this.txtMAIL_PASSWORD.Location = new System.Drawing.Point(79, 62);
            this.txtMAIL_PASSWORD.Name = "txtMAIL_PASSWORD";
            this.txtMAIL_PASSWORD.Size = new System.Drawing.Size(146, 22);
            this.txtMAIL_PASSWORD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密碼";
            // 
            // txtMAIL_ACCOUNT
            // 
            this.txtMAIL_ACCOUNT.Location = new System.Drawing.Point(79, 34);
            this.txtMAIL_ACCOUNT.Name = "txtMAIL_ACCOUNT";
            this.txtMAIL_ACCOUNT.Size = new System.Drawing.Size(146, 22);
            this.txtMAIL_ACCOUNT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "帳號";
            // 
            // txtMAIL_SERVER
            // 
            this.txtMAIL_SERVER.Location = new System.Drawing.Point(79, 6);
            this.txtMAIL_SERVER.Name = "txtMAIL_SERVER";
            this.txtMAIL_SERVER.Size = new System.Drawing.Size(146, 22);
            this.txtMAIL_SERVER.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMTP Server";
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(687, 5);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 0;
            this.btnEmail.Text = "執行";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // txtMAIL_SUBJECT
            // 
            this.txtMAIL_SUBJECT.Location = new System.Drawing.Point(79, 146);
            this.txtMAIL_SUBJECT.Name = "txtMAIL_SUBJECT";
            this.txtMAIL_SUBJECT.Size = new System.Drawing.Size(146, 22);
            this.txtMAIL_SUBJECT.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "標題";
            // 
            // txtMAIL_TO
            // 
            this.txtMAIL_TO.Location = new System.Drawing.Point(79, 118);
            this.txtMAIL_TO.Name = "txtMAIL_TO";
            this.txtMAIL_TO.Size = new System.Drawing.Size(146, 22);
            this.txtMAIL_TO.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "收件者";
            // 
            // txtMAIL_FROM
            // 
            this.txtMAIL_FROM.Location = new System.Drawing.Point(79, 90);
            this.txtMAIL_FROM.Name = "txtMAIL_FROM";
            this.txtMAIL_FROM.Size = new System.Drawing.Size(146, 22);
            this.txtMAIL_FROM.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "寄件者";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(90, 62);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(146, 22);
            this.textBox6.TabIndex = 25;
            // 
            // txtMAIL_BODY
            // 
            this.txtMAIL_BODY.Location = new System.Drawing.Point(79, 174);
            this.txtMAIL_BODY.Name = "txtMAIL_BODY";
            this.txtMAIL_BODY.Size = new System.Drawing.Size(146, 22);
            this.txtMAIL_BODY.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 31;
            this.label12.Text = "內文";
            // 
            // txtOUTPUT
            // 
            this.txtOUTPUT.Location = new System.Drawing.Point(16, 394);
            this.txtOUTPUT.Name = "txtOUTPUT";
            this.txtOUTPUT.Size = new System.Drawing.Size(976, 323);
            this.txtOUTPUT.TabIndex = 1;
            this.txtOUTPUT.Text = "";
            this.txtOUTPUT.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.txtOUTPUT);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.TextBox txtMAIL_SERVER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox txtMAIL_PASSWORD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMAIL_ACCOUNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMAIL_PORT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtMAIL_SUBJECT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMAIL_TO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMAIL_FROM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMAIL_BODY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtOUTPUT;
    }
}

