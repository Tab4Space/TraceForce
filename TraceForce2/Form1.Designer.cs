namespace TraceForce2
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
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login_data = new System.Windows.Forms.Button();
            this.User_Name = new System.Windows.Forms.Label();
            this.User_Id = new System.Windows.Forms.Label();
            this.User_Account = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Data_Volume_Top10_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Max_Price = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Chart_View = new System.Windows.Forms.Button();
            this.Chart_Code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Trade_TxtBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Trade_Btn = new System.Windows.Forms.Button();
            this.Trade_amount = new System.Windows.Forms.TextBox();
            this.Trade_Code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Code_Check = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.simulater = new System.Windows.Forms.TabPage();
            this.simulater_Txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.simulater.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(7, 281);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(10, 10);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(370, 299);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(88, 23);
            this.Login_Button.TabIndex = 1;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.Location = new System.Drawing.Point(471, 299);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(78, 23);
            this.Logout_Button.TabIndex = 2;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login_data);
            this.groupBox1.Controls.Add(this.User_Name);
            this.groupBox1.Controls.Add(this.User_Id);
            this.groupBox1.Controls.Add(this.User_Account);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "계좌정보";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // login_data
            // 
            this.login_data.Location = new System.Drawing.Point(7, 78);
            this.login_data.Name = "login_data";
            this.login_data.Size = new System.Drawing.Size(155, 23);
            this.login_data.TabIndex = 8;
            this.login_data.Text = "계좌조회";
            this.login_data.UseVisualStyleBackColor = true;
            this.login_data.Click += new System.EventHandler(this.login_data_Click);
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Location = new System.Drawing.Point(66, 39);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(81, 12);
            this.User_Name.TabIndex = 7;
            this.User_Name.Text = "로그인하세요.";
            // 
            // User_Id
            // 
            this.User_Id.AutoSize = true;
            this.User_Id.Location = new System.Drawing.Point(66, 20);
            this.User_Id.Name = "User_Id";
            this.User_Id.Size = new System.Drawing.Size(81, 12);
            this.User_Id.TabIndex = 6;
            this.User_Id.Text = "로그인하세요.";
            // 
            // User_Account
            // 
            this.User_Account.FormattingEnabled = true;
            this.User_Account.Location = new System.Drawing.Point(67, 54);
            this.User_Account.Name = "User_Account";
            this.User_Account.Size = new System.Drawing.Size(96, 20);
            this.User_Account.TabIndex = 5;
            this.User_Account.SelectedIndexChanged += new System.EventHandler(this.User_Account_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(43, 36);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(0, 12);
            this.Name.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(41, 20);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(0, 12);
            this.Id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "계좌번호 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // Data_Volume_Top10_Button
            // 
            this.Data_Volume_Top10_Button.Location = new System.Drawing.Point(7, 122);
            this.Data_Volume_Top10_Button.Name = "Data_Volume_Top10_Button";
            this.Data_Volume_Top10_Button.Size = new System.Drawing.Size(168, 27);
            this.Data_Volume_Top10_Button.TabIndex = 4;
            this.Data_Volume_Top10_Button.Text = "거래량 TOP10";
            this.Data_Volume_Top10_Button.UseVisualStyleBackColor = true;
            this.Data_Volume_Top10_Button.Click += new System.EventHandler(this.Data_Volume_Top10_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(367, 275);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Max_Price
            // 
            this.Max_Price.Location = new System.Drawing.Point(7, 155);
            this.Max_Price.Name = "Max_Price";
            this.Max_Price.Size = new System.Drawing.Size(168, 29);
            this.Max_Price.TabIndex = 6;
            this.Max_Price.Text = "상한가종목보기";
            this.Max_Price.UseVisualStyleBackColor = true;
            this.Max_Price.Click += new System.EventHandler(this.Max_Price_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Chart_View);
            this.groupBox2.Controls.Add(this.Chart_Code);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "분봉차트조회";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Chart_View
            // 
            this.Chart_View.Location = new System.Drawing.Point(11, 49);
            this.Chart_View.Name = "Chart_View";
            this.Chart_View.Size = new System.Drawing.Size(150, 22);
            this.Chart_View.TabIndex = 2;
            this.Chart_View.Text = "조회하기";
            this.Chart_View.UseVisualStyleBackColor = true;
            this.Chart_View.Click += new System.EventHandler(this.Chart_View_Click);
            // 
            // Chart_Code
            // 
            this.Chart_Code.Location = new System.Drawing.Point(62, 18);
            this.Chart_Code.Name = "Chart_Code";
            this.Chart_Code.Size = new System.Drawing.Size(100, 21);
            this.Chart_Code.TabIndex = 1;
            this.Chart_Code.TextChanged += new System.EventHandler(this.Chart_Code_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "종목코드";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.simulater);
            this.tabControl1.Location = new System.Drawing.Point(6, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 357);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.axKHOpenAPI1);
            this.tabPage1.Controls.Add(this.Max_Price);
            this.tabPage1.Controls.Add(this.Login_Button);
            this.tabPage1.Controls.Add(this.Logout_Button);
            this.tabPage1.Controls.Add(this.Data_Volume_Top10_Button);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "조회";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "거래";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Trade_TxtBox
            // 
            this.Trade_TxtBox.Location = new System.Drawing.Point(6, 144);
            this.Trade_TxtBox.Multiline = true;
            this.Trade_TxtBox.Name = "Trade_TxtBox";
            this.Trade_TxtBox.Size = new System.Drawing.Size(240, 155);
            this.Trade_TxtBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Trade_TxtBox);
            this.groupBox3.Controls.Add(this.Code_Check);
            this.groupBox3.Controls.Add(this.Trade_Btn);
            this.groupBox3.Controls.Add(this.Trade_amount);
            this.groupBox3.Controls.Add(this.Trade_Code);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(11, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 305);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주문입력";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Trade_Btn
            // 
            this.Trade_Btn.Location = new System.Drawing.Point(16, 89);
            this.Trade_Btn.Name = "Trade_Btn";
            this.Trade_Btn.Size = new System.Drawing.Size(230, 41);
            this.Trade_Btn.TabIndex = 9;
            this.Trade_Btn.Text = "주 문";
            this.Trade_Btn.UseVisualStyleBackColor = true;
            this.Trade_Btn.Click += new System.EventHandler(this.Trade_Btn_Click);
            // 
            // Trade_amount
            // 
            this.Trade_amount.Location = new System.Drawing.Point(77, 58);
            this.Trade_amount.Name = "Trade_amount";
            this.Trade_amount.Size = new System.Drawing.Size(169, 21);
            this.Trade_amount.TabIndex = 6;
            // 
            // Trade_Code
            // 
            this.Trade_Code.Location = new System.Drawing.Point(77, 25);
            this.Trade_Code.Name = "Trade_Code";
            this.Trade_Code.Size = new System.Drawing.Size(126, 21);
            this.Trade_Code.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "주문수량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "종목코드";
            // 
            // Code_Check
            // 
            this.Code_Check.Location = new System.Drawing.Point(196, 24);
            this.Code_Check.Name = "Code_Check";
            this.Code_Check.Size = new System.Drawing.Size(50, 23);
            this.Code_Check.TabIndex = 10;
            this.Code_Check.Text = "조 회";
            this.Code_Check.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 18);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 295);
            this.textBox2.TabIndex = 3;
            // 
            // simulater
            // 
            this.simulater.Controls.Add(this.label6);
            this.simulater.Controls.Add(this.simulater_Txtbox);
            this.simulater.Location = new System.Drawing.Point(4, 22);
            this.simulater.Name = "simulater";
            this.simulater.Padding = new System.Windows.Forms.Padding(3);
            this.simulater.Size = new System.Drawing.Size(557, 331);
            this.simulater.TabIndex = 2;
            this.simulater.Text = "시뮬레이터";
            this.simulater.UseVisualStyleBackColor = true;
            // 
            // simulater_Txtbox
            // 
            this.simulater_Txtbox.Location = new System.Drawing.Point(254, 6);
            this.simulater_Txtbox.Multiline = true;
            this.simulater_Txtbox.Name = "simulater_Txtbox";
            this.simulater_Txtbox.Size = new System.Drawing.Size(285, 308);
            this.simulater_Txtbox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "종목코드";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 364);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.simulater.ResumeLayout(false);
            this.simulater.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox User_Account;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Label User_Id;
        private System.Windows.Forms.Button Data_Volume_Top10_Button;
        private System.Windows.Forms.Button login_data;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Max_Price;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Chart_View;
        private System.Windows.Forms.TextBox Chart_Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Trade_TxtBox;
        private System.Windows.Forms.Button Trade_Btn;
        private System.Windows.Forms.TextBox Trade_amount;
        private System.Windows.Forms.TextBox Trade_Code;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Code_Check;
        private System.Windows.Forms.TabPage simulater;
        private System.Windows.Forms.TextBox simulater_Txtbox;
        private System.Windows.Forms.Label label6;
    }
}

