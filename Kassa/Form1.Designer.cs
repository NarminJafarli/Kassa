namespace Kassa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            btnhesablama = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btndot = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnX = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            total = new Label();
            paid = new Label();
            returned = new Label();
            listBox1 = new ListBox();
            error = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(44, 39);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "Məhsul kodu";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox1.Location = new Point(31, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 34);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(213, 25);
            button1.Name = "button1";
            button1.Size = new Size(151, 42);
            button1.TabIndex = 2;
            button1.Text = "Kod siyahısı";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(213, 83);
            button2.Name = "button2";
            button2.Size = new Size(151, 43);
            button2.TabIndex = 3;
            button2.Text = "Əlavə et";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnhesablama);
            groupBox1.Controls.Add(btn0);
            groupBox1.Controls.Add(btn9);
            groupBox1.Controls.Add(btn8);
            groupBox1.Controls.Add(btn7);
            groupBox1.Controls.Add(btndot);
            groupBox1.Controls.Add(btn6);
            groupBox1.Controls.Add(btn5);
            groupBox1.Controls.Add(btn4);
            groupBox1.Controls.Add(btnX);
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(46, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 324);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Məbləğ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnhesablama
            // 
            btnhesablama.BackColor = SystemColors.ButtonHighlight;
            btnhesablama.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnhesablama.Location = new Point(26, 245);
            btnhesablama.Name = "btnhesablama";
            btnhesablama.Size = new Size(226, 56);
            btnhesablama.TabIndex = 13;
            btnhesablama.Text = "Hesablamaq";
            btnhesablama.UseVisualStyleBackColor = false;
            btnhesablama.Click += btnhesablama_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ButtonHighlight;
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(202, 192);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 47);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonHighlight;
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(138, 192);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 47);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonHighlight;
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(82, 192);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 47);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonHighlight;
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(26, 192);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 47);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btndot
            // 
            btndot.BackColor = SystemColors.ButtonHighlight;
            btndot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btndot.Location = new Point(202, 139);
            btndot.Name = "btndot";
            btndot.Size = new Size(50, 47);
            btndot.TabIndex = 8;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = false;
            btndot.Click += btndot_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonHighlight;
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(138, 139);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 47);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonHighlight;
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(82, 139);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 47);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonHighlight;
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(26, 139);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 47);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnX
            // 
            btnX.BackColor = SystemColors.ButtonHighlight;
            btnX.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnX.Location = new Point(202, 86);
            btnX.Name = "btnX";
            btnX.Size = new Size(50, 47);
            btnX.TabIndex = 4;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonHighlight;
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(138, 86);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 47);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonHighlight;
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(82, 86);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 47);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonHighlight;
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(26, 86);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 47);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox2.Location = new Point(22, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 34);
            textBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(536, 27);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 5;
            label2.Text = "Ümumi məbləğ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(519, 60);
            label3.Name = "label3";
            label3.Size = new Size(178, 28);
            label3.TabIndex = 6;
            label3.Text = "Ödənilən məbləğ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(554, 92);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 7;
            label4.Text = "Qalığ məbləğ:";
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = SystemColors.ActiveCaption;
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            total.Location = new Point(745, 27);
            total.Name = "total";
            total.Size = new Size(92, 28);
            total.TabIndex = 8;
            total.Text = "0.00 azn";
            total.Click += label5_Click;
            // 
            // paid
            // 
            paid.AutoSize = true;
            paid.BackColor = SystemColors.ActiveCaption;
            paid.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            paid.Location = new Point(745, 60);
            paid.Name = "paid";
            paid.Size = new Size(92, 28);
            paid.TabIndex = 9;
            paid.Text = "0.00 azn";
            // 
            // returned
            // 
            returned.AutoSize = true;
            returned.BackColor = SystemColors.ActiveCaption;
            returned.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            returned.Location = new Point(745, 95);
            returned.Name = "returned";
            returned.Size = new Size(92, 28);
            returned.TabIndex = 10;
            returned.Text = "0.00 azn";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ButtonHighlight;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(461, 210);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(394, 312);
            listBox1.TabIndex = 11;
            // 
            // error
            // 
            error.AutoSize = true;
            error.BackColor = SystemColors.ActiveCaption;
            error.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            error.ForeColor = Color.Red;
            error.Location = new Point(550, 144);
            error.Name = "error";
            error.Size = new Size(287, 17);
            error.TabIndex = 12;
            error.Text = "Ödənilən məbləğ ümumi məbləğdən kiçikdir.";
            error.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(384, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 104);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(867, 598);
            Controls.Add(pictureBox1);
            Controls.Add(error);
            Controls.Add(listBox1);
            Controls.Add(returned);
            Controls.Add(paid);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button btnhesablama;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btndot;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnX;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label total;
        private Label paid;
        private Label returned;
        private ListBox listBox1;
        private Label error;
        private PictureBox pictureBox1;
    }
}
