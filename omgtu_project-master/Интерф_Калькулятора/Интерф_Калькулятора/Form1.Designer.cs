namespace Интерф_Калькулятора
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.onenumber2 = new System.Windows.Forms.TextBox();
            this.twonumber3 = new System.Windows.Forms.TextBox();
            this.result1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pow2 = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.С = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.minuse = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // onenumber2
            // 
            this.onenumber2.Location = new System.Drawing.Point(7, 39);
            this.onenumber2.Name = "onenumber2";
            this.onenumber2.Size = new System.Drawing.Size(143, 22);
            this.onenumber2.TabIndex = 0;
            // 
            // twonumber3
            // 
            this.twonumber3.Location = new System.Drawing.Point(263, 39);
            this.twonumber3.Name = "twonumber3";
            this.twonumber3.Size = new System.Drawing.Size(126, 22);
            this.twonumber3.TabIndex = 1;
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(7, 84);
            this.result1.Name = "result1";
            this.result1.ReadOnly = true;
            this.result1.Size = new System.Drawing.Size(382, 22);
            this.result1.TabIndex = 2;
            this.result1.TextChanged += new System.EventHandler(this.result1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pow2);
            this.groupBox1.Controls.Add(this.ctg);
            this.groupBox1.Controls.Add(this.del);
            this.groupBox1.Controls.Add(this.tg);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.cos);
            this.groupBox1.Controls.Add(this.sin);
            this.groupBox1.Controls.Add(this.С);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dot);
            this.groupBox1.Controls.Add(this.equally);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.division);
            this.groupBox1.Controls.Add(this.multiplication);
            this.groupBox1.Controls.Add(this.plus);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.minuse);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 241);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // pow2
            // 
            this.pow2.Location = new System.Drawing.Point(19, 41);
            this.pow2.Name = "pow2";
            this.pow2.Size = new System.Drawing.Size(44, 32);
            this.pow2.TabIndex = 50;
            this.pow2.Text = "2^x";
            this.pow2.UseVisualStyleBackColor = true;
            this.pow2.Click += new System.EventHandler(this.funcChoose);
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(219, 153);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(44, 32);
            this.ctg.TabIndex = 49;
            this.ctg.Text = "ctg";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.funcChoose);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(69, 41);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(44, 32);
            this.del.TabIndex = 48;
            this.del.Text = "del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.delete_Button);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(219, 118);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(44, 32);
            this.tg.TabIndex = 24;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.funcChoose);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(119, 80);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 32);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttALL2);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(219, 80);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(44, 32);
            this.cos.TabIndex = 23;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.funcChoose);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(219, 41);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(44, 32);
            this.sin.TabIndex = 22;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.funcChoose);
            // 
            // С
            // 
            this.С.Location = new System.Drawing.Point(119, 41);
            this.С.Name = "С";
            this.С.Size = new System.Drawing.Size(44, 32);
            this.С.TabIndex = 0;
            this.С.Text = "C";
            this.С.UseVisualStyleBackColor = true;
            this.С.Click += new System.EventHandler(this.clearResult);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttALL2);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(69, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttALL2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttALL2);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(69, 193);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(44, 32);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // equally
            // 
            this.equally.Location = new System.Drawing.Point(119, 193);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(94, 32);
            this.equally.TabIndex = 18;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = true;
            this.equally.Click += new System.EventHandler(this.equally_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(119, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 32);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttALL2);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(19, 192);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 32);
            this.button10.TabIndex = 16;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttALL2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttALL2);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 78);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 32);
            this.button7.TabIndex = 4;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttALL2);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(169, 41);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(44, 32);
            this.division.TabIndex = 15;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operChoose);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(169, 78);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(44, 32);
            this.multiplication.TabIndex = 11;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.operChoose);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(169, 154);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(44, 32);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operChoose);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttALL2);
            // 
            // minuse
            // 
            this.minuse.Location = new System.Drawing.Point(169, 115);
            this.minuse.Name = "minuse";
            this.minuse.Size = new System.Drawing.Size(44, 32);
            this.minuse.TabIndex = 7;
            this.minuse.Text = "-";
            this.minuse.UseVisualStyleBackColor = true;
            this.minuse.Click += new System.EventHandler(this.operChoose);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(69, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 32);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttALL2);
            // 
            // comboBox4
            // 
            this.comboBox4.Location = new System.Drawing.Point(170, 39);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(70, 22);
            this.comboBox4.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(420, 377);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.twonumber3);
            this.Controls.Add(this.onenumber2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox onenumber2;
        private System.Windows.Forms.TextBox twonumber3;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button С;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equally;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button minuse;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.TextBox comboBox4;
        private System.Windows.Forms.Button pow2;
    }
}

