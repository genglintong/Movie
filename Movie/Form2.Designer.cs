﻿using System.Configuration;

namespace Movie
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomNum = new System.Windows.Forms.TextBox();
            this.movieName = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "厅号(填入数字)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "电影名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "日期";
            // 
            // roomNum
            // 
            this.roomNum.Location = new System.Drawing.Point(121, 40);
            this.roomNum.Name = "roomNum";
            this.roomNum.Size = new System.Drawing.Size(104, 21);
            this.roomNum.TabIndex = 5;
            this.roomNum.Text = ConfigurationManager.AppSettings["roomNum"];
            // 
            // movieName
            // 
            this.movieName.Location = new System.Drawing.Point(121, 77);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(104, 21);
            this.movieName.TabIndex = 6;
            this.movieName.Text = ConfigurationManager.AppSettings["movieName"];
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(121, 117);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(104, 21);
            this.time.TabIndex = 7;
            this.time.Text = ConfigurationManager.AppSettings["time"];
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(121, 159);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(104, 21);
            this.date.TabIndex = 8;
            this.date.Text = ConfigurationManager.AppSettings["date"];
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "价格";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(121, 197);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(104, 21);
            this.price.TabIndex = 10;
            this.price.Text = ConfigurationManager.AppSettings["price"];
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 272);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.roomNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomNum;
        private System.Windows.Forms.TextBox movieName;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
    }
}