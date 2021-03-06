﻿namespace TransportGUI
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
            this.comboBoxVon = new System.Windows.Forms.ComboBox();
            this.comboBoxNach = new System.Windows.Forms.ComboBox();
            this.change_btn = new System.Windows.Forms.Button();
            this.Date_setter = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // comboBoxVon
            // 
            this.comboBoxVon.FormattingEnabled = true;
            this.comboBoxVon.Location = new System.Drawing.Point(64, 12);
            this.comboBoxVon.Name = "comboBoxVon";
            this.comboBoxVon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVon.TabIndex = 0;
            this.comboBoxVon.DropDown += new System.EventHandler(this.comboBoxVon_DropDown);
            this.comboBoxVon.TextUpdate += new System.EventHandler(this.comboBoxVon_TextUpdate);
            // 
            // comboBoxNach
            // 
            this.comboBoxNach.FormattingEnabled = true;
            this.comboBoxNach.Location = new System.Drawing.Point(64, 71);
            this.comboBoxNach.Name = "comboBoxNach";
            this.comboBoxNach.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNach.TabIndex = 1;
            this.comboBoxNach.DropDown += new System.EventHandler(this.comboBoxNach_DropDown);
            this.comboBoxNach.TextUpdate += new System.EventHandler(this.comboBoxNach_TextUpdate);
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(64, 39);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 23);
            this.change_btn.TabIndex = 2;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click_1);
            // 
            // Date_setter
            // 
            this.Date_setter.CustomFormat = "dd.MM.yyyy || HH.mm";
            this.Date_setter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_setter.Location = new System.Drawing.Point(64, 122);
            this.Date_setter.Name = "Date_setter";
            this.Date_setter.Size = new System.Drawing.Size(131, 20);
            this.Date_setter.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "00h",
            "01h",
            "02h",
            "03h",
            "04h",
            "05h",
            "06h",
            "07h",
            "08h",
            "09h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h",
            "18h",
            "19h",
            "20h",
            "21h",
            "22h",
            "23h"});
            this.comboBox3.Location = new System.Drawing.Point(219, 124);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(57, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nach";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Verbindungen suchen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Verbindung_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "00min",
            "01min",
            "02min",
            "03min",
            "04min",
            "05min",
            "06min",
            "07min",
            "08min",
            "09min",
            "10min",
            "11min",
            "12min",
            "13min",
            "14min",
            "15min",
            "16min",
            "17min",
            "18min",
            "19min",
            "20min",
            "21min",
            "22min",
            "23min",
            "24min",
            "25min",
            "26min",
            "27min",
            "28min",
            "29min",
            "30min",
            "31min",
            "32min",
            "33min",
            "34min",
            "35min",
            "36min",
            "37min",
            "38min",
            "39min",
            "40min",
            "41min",
            "42min",
            "43min",
            "44min",
            "45min",
            "46min",
            "47min",
            "48min",
            "49min",
            "50min",
            "51min",
            "52min",
            "53min",
            "54min",
            "55min",
            "56min",
            "57min",
            "58min",
            "59min"});
            this.comboBox4.Location = new System.Drawing.Point(297, 124);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(58, 21);
            this.comboBox4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = ":";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 336);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 529);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Date_setter);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.comboBoxNach);
            this.Controls.Add(this.comboBoxVon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVon;
        private System.Windows.Forms.ComboBox comboBoxNach;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.DateTimePicker Date_setter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
    }
}

