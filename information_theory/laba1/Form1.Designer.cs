﻿namespace laba1
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
            this.encrypt = new System.Windows.Forms.Button();
            this.tm1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tkey1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tkey2 = new System.Windows.Forms.TextBox();
            this.fileread1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tencr1 = new System.Windows.Forms.TextBox();
            this.tm2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileread2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tkey4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tt1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tkey3 = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.save4 = new System.Windows.Forms.Button();
            this.save3 = new System.Windows.Forms.Button();
            this.tm4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fileread4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tt2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tkey6 = new System.Windows.Forms.TextBox();
            this.decrypt1 = new System.Windows.Forms.Button();
            this.tencr2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.fileread3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tkey5 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tm3 = new System.Windows.Forms.TextBox();
            this.encrypt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(55, 312);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(189, 50);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "Зашифровать";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // tm1
            // 
            this.tm1.Location = new System.Drawing.Point(73, 112);
            this.tm1.Name = "tm1";
            this.tm1.Size = new System.Drawing.Size(153, 31);
            this.tm1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Столбцовый метод";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1004, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Алгоритм Вижинера,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите ключ1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(72, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите текст";
            // 
            // tkey1
            // 
            this.tkey1.Location = new System.Drawing.Point(70, 189);
            this.tkey1.Name = "tkey1";
            this.tkey1.Size = new System.Drawing.Size(153, 31);
            this.tkey1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(624, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Зашифровка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(624, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Расшифровка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(68, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Введите ключ2";
            // 
            // tkey2
            // 
            this.tkey2.Location = new System.Drawing.Point(70, 265);
            this.tkey2.Name = "tkey2";
            this.tkey2.Size = new System.Drawing.Size(153, 31);
            this.tkey2.TabIndex = 15;
            // 
            // fileread1
            // 
            this.fileread1.Location = new System.Drawing.Point(294, 259);
            this.fileread1.Name = "fileread1";
            this.fileread1.Size = new System.Drawing.Size(182, 103);
            this.fileread1.TabIndex = 17;
            this.fileread1.Text = "Зашифровать по данным из файла";
            this.fileread1.UseVisualStyleBackColor = true;
            this.fileread1.Click += new System.EventHandler(this.fileread1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(23, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Результат";
            // 
            // tencr1
            // 
            this.tencr1.Location = new System.Drawing.Point(144, 390);
            this.tencr1.Name = "tencr1";
            this.tencr1.Size = new System.Drawing.Size(179, 31);
            this.tencr1.TabIndex = 19;
            this.tencr1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tm2
            // 
            this.tm2.Location = new System.Drawing.Point(144, 832);
            this.tm2.Name = "tm2";
            this.tm2.Size = new System.Drawing.Size(179, 31);
            this.tm2.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 835);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Результат";
            // 
            // fileread2
            // 
            this.fileread2.Location = new System.Drawing.Point(288, 705);
            this.fileread2.Name = "fileread2";
            this.fileread2.Size = new System.Drawing.Size(188, 103);
            this.fileread2.TabIndex = 27;
            this.fileread2.Text = "Расшифровать по данным из файла";
            this.fileread2.UseVisualStyleBackColor = true;
            this.fileread2.Click += new System.EventHandler(this.fileread2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(68, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Введите ключ2";
            // 
            // tkey4
            // 
            this.tkey4.Location = new System.Drawing.Point(70, 705);
            this.tkey4.Name = "tkey4";
            this.tkey4.Size = new System.Drawing.Size(153, 31);
            this.tkey4.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(68, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Введите шифр";
            // 
            // tt1
            // 
            this.tt1.Location = new System.Drawing.Point(70, 554);
            this.tt1.Name = "tt1";
            this.tt1.Size = new System.Drawing.Size(153, 31);
            this.tt1.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(68, 599);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Введите ключ1";
            // 
            // tkey3
            // 
            this.tkey3.Location = new System.Drawing.Point(70, 630);
            this.tkey3.Name = "tkey3";
            this.tkey3.Size = new System.Drawing.Size(153, 31);
            this.tkey3.TabIndex = 21;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(55, 758);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(189, 50);
            this.decrypt.TabIndex = 20;
            this.decrypt.Text = "Расшифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(336, 379);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(140, 50);
            this.save1.TabIndex = 30;
            this.save1.Text = "Сохранить";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(330, 822);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(146, 50);
            this.save2.TabIndex = 31;
            this.save2.Text = "Сохранить";
            this.save2.UseVisualStyleBackColor = true;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(956, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(385, 31);
            this.label13.TabIndex = 32;
            this.label13.Text = "самогенерирующийся ключ";
            // 
            // save4
            // 
            this.save4.Location = new System.Drawing.Point(1241, 822);
            this.save4.Name = "save4";
            this.save4.Size = new System.Drawing.Size(146, 50);
            this.save4.TabIndex = 54;
            this.save4.Text = "Сохранить";
            this.save4.UseVisualStyleBackColor = true;
            this.save4.Click += new System.EventHandler(this.save4_Click);
            // 
            // save3
            // 
            this.save3.Location = new System.Drawing.Point(1247, 383);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(140, 50);
            this.save3.TabIndex = 53;
            this.save3.Text = "Сохранить";
            this.save3.UseVisualStyleBackColor = true;
            this.save3.Click += new System.EventHandler(this.save3_Click);
            // 
            // tm4
            // 
            this.tm4.Location = new System.Drawing.Point(1058, 832);
            this.tm4.Name = "tm4";
            this.tm4.Size = new System.Drawing.Size(170, 31);
            this.tm4.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(937, 832);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 25);
            this.label14.TabIndex = 51;
            this.label14.Text = "Результат";
            // 
            // fileread4
            // 
            this.fileread4.Location = new System.Drawing.Point(1199, 700);
            this.fileread4.Name = "fileread4";
            this.fileread4.Size = new System.Drawing.Size(188, 103);
            this.fileread4.TabIndex = 50;
            this.fileread4.Text = "Расшифровать по данным из файла";
            this.fileread4.UseVisualStyleBackColor = true;
            this.fileread4.Click += new System.EventHandler(this.fileread4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(976, 551);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 25);
            this.label16.TabIndex = 47;
            this.label16.Text = "Введите шифр";
            // 
            // tt2
            // 
            this.tt2.Location = new System.Drawing.Point(978, 589);
            this.tt2.Name = "tt2";
            this.tt2.Size = new System.Drawing.Size(153, 31);
            this.tt2.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(980, 647);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 25);
            this.label17.TabIndex = 45;
            this.label17.Text = "Введите ключ";
            // 
            // tkey6
            // 
            this.tkey6.Location = new System.Drawing.Point(978, 692);
            this.tkey6.Name = "tkey6";
            this.tkey6.Size = new System.Drawing.Size(153, 31);
            this.tkey6.TabIndex = 44;
            // 
            // decrypt1
            // 
            this.decrypt1.Location = new System.Drawing.Point(962, 753);
            this.decrypt1.Name = "decrypt1";
            this.decrypt1.Size = new System.Drawing.Size(189, 50);
            this.decrypt1.TabIndex = 43;
            this.decrypt1.Text = "Расшифровать";
            this.decrypt1.UseVisualStyleBackColor = true;
            this.decrypt1.Click += new System.EventHandler(this.decrypt1_Click);
            // 
            // tencr2
            // 
            this.tencr2.Location = new System.Drawing.Point(1071, 393);
            this.tencr2.Name = "tencr2";
            this.tencr2.Size = new System.Drawing.Size(157, 31);
            this.tencr2.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(937, 396);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 25);
            this.label18.TabIndex = 41;
            this.label18.Text = "Результат";
            // 
            // fileread3
            // 
            this.fileread3.Location = new System.Drawing.Point(1205, 265);
            this.fileread3.Name = "fileread3";
            this.fileread3.Size = new System.Drawing.Size(182, 103);
            this.fileread3.TabIndex = 40;
            this.fileread3.Text = "Зашифровать по данным из файла";
            this.fileread3.UseVisualStyleBackColor = true;
            this.fileread3.Click += new System.EventHandler(this.fileread3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(976, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 25);
            this.label20.TabIndex = 37;
            this.label20.Text = "Введите текст";
            // 
            // tkey5
            // 
            this.tkey5.Location = new System.Drawing.Point(976, 254);
            this.tkey5.Name = "tkey5";
            this.tkey5.Size = new System.Drawing.Size(153, 31);
            this.tkey5.TabIndex = 36;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(977, 216);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 25);
            this.label21.TabIndex = 35;
            this.label21.Text = "Введите ключ";
            // 
            // tm3
            // 
            this.tm3.Location = new System.Drawing.Point(976, 164);
            this.tm3.Name = "tm3";
            this.tm3.Size = new System.Drawing.Size(153, 31);
            this.tm3.TabIndex = 34;
            // 
            // encrypt1
            // 
            this.encrypt1.Location = new System.Drawing.Point(962, 319);
            this.encrypt1.Name = "encrypt1";
            this.encrypt1.Size = new System.Drawing.Size(189, 50);
            this.encrypt1.TabIndex = 33;
            this.encrypt1.Text = "Зашифровать";
            this.encrypt1.UseVisualStyleBackColor = true;
            this.encrypt1.Click += new System.EventHandler(this.encrypt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 895);
            this.Controls.Add(this.save4);
            this.Controls.Add(this.save3);
            this.Controls.Add(this.tm4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fileread4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tt2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tkey6);
            this.Controls.Add(this.decrypt1);
            this.Controls.Add(this.tencr2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.fileread3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tkey5);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tm3);
            this.Controls.Add(this.encrypt1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.save2);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.tm2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fileread2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tkey4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tt1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tkey3);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.tencr1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fileread1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tkey2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tkey1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tm1);
            this.Controls.Add(this.encrypt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.TextBox tm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tkey1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tkey2;
        private System.Windows.Forms.Button fileread1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tencr1;
        private System.Windows.Forms.TextBox tm2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fileread2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tkey4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tt1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tkey3;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button save4;
        private System.Windows.Forms.Button save3;
        private System.Windows.Forms.TextBox tm4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button fileread4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tt2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tkey6;
        private System.Windows.Forms.Button decrypt1;
        private System.Windows.Forms.TextBox tencr2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button fileread3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tkey5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tm3;
        private System.Windows.Forms.Button encrypt1;
    }
}

