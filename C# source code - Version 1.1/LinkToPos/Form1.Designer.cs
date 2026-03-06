namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_Paring_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Auth_token = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_Uti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Tid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_IP_address = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox_TransType = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Disable_printing = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox_Auto_increase = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.comboBox_Post_approval = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "GET - PairReqest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 490);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 448);
            this.textBox1.TabIndex = 1;
            // 
            // textBox_Paring_code
            // 
            this.textBox_Paring_code.Location = new System.Drawing.Point(152, 137);
            this.textBox_Paring_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Paring_code.Name = "textBox_Paring_code";
            this.textBox_Paring_code.Size = new System.Drawing.Size(110, 26);
            this.textBox_Paring_code.TabIndex = 2;
            this.textBox_Paring_code.Text = "1234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paring code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Auth token:";
            // 
            // textBox_Auth_token
            // 
            this.textBox_Auth_token.Location = new System.Drawing.Point(142, 211);
            this.textBox_Auth_token.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Auth_token.Name = "textBox_Auth_token";
            this.textBox_Auth_token.Size = new System.Drawing.Size(187, 26);
            this.textBox_Auth_token.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "POST - Request (Sale)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Uti
            // 
            this.textBox_Uti.Location = new System.Drawing.Point(88, 280);
            this.textBox_Uti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Uti.Name = "textBox_Uti";
            this.textBox_Uti.Size = new System.Drawing.Size(374, 26);
            this.textBox_Uti.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uti:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "GET - GetRequest";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "DEL - DeleteRequest";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount:";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(120, 244);
            this.textBox_Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(104, 26);
            this.textBox_Amount.TabIndex = 11;
            this.textBox_Amount.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(453, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Local link - Test app";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(895, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 664);
            this.listBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Serial number:";
            // 
            // textBox_Tid
            // 
            this.textBox_Tid.Location = new System.Drawing.Point(166, 175);
            this.textBox_Tid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Tid.Name = "textBox_Tid";
            this.textBox_Tid.Size = new System.Drawing.Size(144, 26);
            this.textBox_Tid.TabIndex = 16;
            this.textBox_Tid.Text = "1240045816";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "IP address:";
            // 
            // textBox_IP_address
            // 
            this.textBox_IP_address.Location = new System.Drawing.Point(137, 100);
            this.textBox_IP_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_IP_address.Name = "textBox_IP_address";
            this.textBox_IP_address.Size = new System.Drawing.Size(173, 26);
            this.textBox_IP_address.TabIndex = 17;
            this.textBox_IP_address.Text = "192.168.20.226:8080";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(494, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 37);
            this.button5.TabIndex = 19;
            this.button5.Text = "GET - StatusRequest";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(753, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 37);
            this.button6.TabIndex = 20;
            this.button6.Text = "GET - X report";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(753, 141);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 37);
            this.button7.TabIndex = 21;
            this.button7.Text = "GET - Z report";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox_TransType
            // 
            this.comboBox_TransType.FormattingEnabled = true;
            this.comboBox_TransType.Items.AddRange(new object[] {
            "SALE",
            "REFUND"});
            this.comboBox_TransType.Location = new System.Drawing.Point(363, 243);
            this.comboBox_TransType.Name = "comboBox_TransType";
            this.comboBox_TransType.Size = new System.Drawing.Size(125, 28);
            this.comboBox_TransType.TabIndex = 23;
            this.comboBox_TransType.Text = "SALE";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(493, 230);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(213, 37);
            this.button9.TabIndex = 24;
            this.button9.Text = "POST - Request (Reversal)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Disable printing:";
            // 
            // comboBox_Disable_printing
            // 
            this.comboBox_Disable_printing.FormattingEnabled = true;
            this.comboBox_Disable_printing.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBox_Disable_printing.Location = new System.Drawing.Point(176, 323);
            this.comboBox_Disable_printing.Name = "comboBox_Disable_printing";
            this.comboBox_Disable_printing.Size = new System.Drawing.Size(125, 28);
            this.comboBox_Disable_printing.TabIndex = 26;
            this.comboBox_Disable_printing.Text = "true";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 465);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "API reply:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(891, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "API reply with linefeed:";
            // 
            // checkBox_Auto_increase
            // 
            this.checkBox_Auto_increase.AutoSize = true;
            this.checkBox_Auto_increase.Location = new System.Drawing.Point(231, 245);
            this.checkBox_Auto_increase.Name = "checkBox_Auto_increase";
            this.checkBox_Auto_increase.Size = new System.Drawing.Size(126, 24);
            this.checkBox_Auto_increase.TabIndex = 29;
            this.checkBox_Auto_increase.Text = "Auto increase";
            this.checkBox_Auto_increase.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(493, 445);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(212, 37);
            this.button10.TabIndex = 30;
            this.button10.Text = "Auto timer";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(274, 445);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(213, 37);
            this.button11.TabIndex = 31;
            this.button11.Text = "POST - Approval request";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // comboBox_Post_approval
            // 
            this.comboBox_Post_approval.FormattingEnabled = true;
            this.comboBox_Post_approval.Items.AddRange(new object[] {
            "APPROVED",
            "DECLINED"});
            this.comboBox_Post_approval.Location = new System.Drawing.Point(176, 357);
            this.comboBox_Post_approval.Name = "comboBox_Post_approval";
            this.comboBox_Post_approval.Size = new System.Drawing.Size(125, 28);
            this.comboBox_Post_approval.TabIndex = 34;
            this.comboBox_Post_approval.Text = "APPROVED";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 360);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Post - Approval:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(494, 360);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(212, 37);
            this.button8.TabIndex = 35;
            this.button8.Text = "POST - Display line";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(494, 403);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(212, 37);
            this.button12.TabIndex = 36;
            this.button12.Text = "POST - Print";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 976);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.comboBox_Post_approval);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.checkBox_Auto_increase);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_Disable_printing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.comboBox_TransType);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_IP_address);
            this.Controls.Add(this.textBox_Tid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Uti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Auth_token);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Paring_code);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Local link - Test app - Version 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_Paring_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Auth_token;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Uti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Tid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_IP_address;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox_TransType;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Disable_printing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_Auto_increase;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox_Post_approval;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
    }
}

