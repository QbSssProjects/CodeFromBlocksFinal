using System;
using System.ComponentModel;

namespace WindowsFormsApp2
{
    partial class ChoosseVarOn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddRadio = new System.Windows.Forms.RadioButton();
            this.SubRadio = new System.Windows.Forms.RadioButton();
            this.MultipyRadio = new System.Windows.Forms.RadioButton();
            this.DivRadio = new System.Windows.Forms.RadioButton();
            this.ModRadio = new System.Windows.Forms.RadioButton();
            this.OnVarRadio = new System.Windows.Forms.RadioButton();
            this.OnNumberRadio = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Sub2 = new System.Windows.Forms.Button();
            this.Sub1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Multipy2 = new System.Windows.Forms.Button();
            this.Multipy1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Div2 = new System.Windows.Forms.Button();
            this.Div1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Mod2 = new System.Windows.Forms.Button();
            this.Mod1 = new System.Windows.Forms.Button();
            this.OnNumer = new System.Windows.Forms.NumericUpDown();
            this.Add1 = new System.Windows.Forms.Button();
            this.Add2 = new System.Windows.Forms.Button();
            this.OnVar = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OnNumer)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(130, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddRadio
            // 
            this.AddRadio.Location = new System.Drawing.Point(14, 65);
            this.AddRadio.Name = "AddRadio";
            this.AddRadio.Size = new System.Drawing.Size(137, 30);
            this.AddRadio.TabIndex = 1;
            this.AddRadio.TabStop = true;
            this.AddRadio.Text = "DODAWANIE";
            this.AddRadio.UseVisualStyleBackColor = true;
            this.AddRadio.CheckedChanged += new System.EventHandler(this.AddRadio_CheckedChanged);
            // 
            // SubRadio
            // 
            this.SubRadio.Location = new System.Drawing.Point(14, 101);
            this.SubRadio.Name = "SubRadio";
            this.SubRadio.Size = new System.Drawing.Size(137, 30);
            this.SubRadio.TabIndex = 2;
            this.SubRadio.TabStop = true;
            this.SubRadio.Text = "ODEJMOWANIE";
            this.SubRadio.UseVisualStyleBackColor = true;
            this.SubRadio.CheckedChanged += new System.EventHandler(this.SubRadio_CheckedChanged);
            // 
            // MultipyRadio
            // 
            this.MultipyRadio.Location = new System.Drawing.Point(14, 137);
            this.MultipyRadio.Name = "MultipyRadio";
            this.MultipyRadio.Size = new System.Drawing.Size(137, 30);
            this.MultipyRadio.TabIndex = 3;
            this.MultipyRadio.TabStop = true;
            this.MultipyRadio.Text = "MNOŻENIE";
            this.MultipyRadio.UseVisualStyleBackColor = true;
            this.MultipyRadio.CheckedChanged += new System.EventHandler(this.MultipyRadio_CheckedChanged);
            // 
            // DivRadio
            // 
            this.DivRadio.Location = new System.Drawing.Point(14, 173);
            this.DivRadio.Name = "DivRadio";
            this.DivRadio.Size = new System.Drawing.Size(137, 30);
            this.DivRadio.TabIndex = 4;
            this.DivRadio.TabStop = true;
            this.DivRadio.Text = "DZIELENIE";
            this.DivRadio.UseVisualStyleBackColor = true;
            this.DivRadio.CheckedChanged += new System.EventHandler(this.DivRadio_CheckedChanged);
            // 
            // ModRadio
            // 
            this.ModRadio.Location = new System.Drawing.Point(14, 209);
            this.ModRadio.Name = "ModRadio";
            this.ModRadio.Size = new System.Drawing.Size(137, 30);
            this.ModRadio.TabIndex = 5;
            this.ModRadio.TabStop = true;
            this.ModRadio.Text = "RESZTA Z DZIELENIA";
            this.ModRadio.UseVisualStyleBackColor = true;
            this.ModRadio.CheckedChanged += new System.EventHandler(this.ModRadio_CheckedChanged);
            // 
            // OnVarRadio
            // 
            this.OnVarRadio.Location = new System.Drawing.Point(14, 245);
            this.OnVarRadio.Name = "OnVarRadio";
            this.OnVarRadio.Size = new System.Drawing.Size(137, 30);
            this.OnVarRadio.TabIndex = 6;
            this.OnVarRadio.TabStop = true;
            this.OnVarRadio.Text = "NA ZMIENNĄ";
            this.OnVarRadio.UseVisualStyleBackColor = true;
            this.OnVarRadio.CheckedChanged += new System.EventHandler(this.OnVarRadio_CheckedChanged);
            // 
            // OnNumberRadio
            // 
            this.OnNumberRadio.Location = new System.Drawing.Point(14, 281);
            this.OnNumberRadio.Name = "OnNumberRadio";
            this.OnNumberRadio.Size = new System.Drawing.Size(137, 30);
            this.OnNumberRadio.TabIndex = 7;
            this.OnNumberRadio.TabStop = true;
            this.OnNumberRadio.Text = "NA INNĄ LICZBĘ";
            this.OnNumberRadio.UseVisualStyleBackColor = true;
            this.OnNumberRadio.CheckedChanged += new System.EventHandler(this.OnNumberRadio_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(242, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(11, 13);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(242, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(11, 13);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sub2
            // 
            this.Sub2.Enabled = false;
            this.Sub2.Location = new System.Drawing.Point(263, 105);
            this.Sub2.Name = "Sub2";
            this.Sub2.Size = new System.Drawing.Size(71, 23);
            this.Sub2.TabIndex = 12;
            this.Sub2.Text = "Wybierz";
            this.Sub2.UseVisualStyleBackColor = true;
            this.Sub2.Click += new System.EventHandler(this.Sub2_Click);
            // 
            // Sub1
            // 
            this.Sub1.Enabled = false;
            this.Sub1.Location = new System.Drawing.Point(157, 105);
            this.Sub1.Name = "Sub1";
            this.Sub1.Size = new System.Drawing.Size(71, 23);
            this.Sub1.TabIndex = 11;
            this.Sub1.Text = "Wybierz";
            this.Sub1.UseVisualStyleBackColor = true;
            this.Sub1.Click += new System.EventHandler(this.Sub1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(242, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(11, 13);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Multipy2
            // 
            this.Multipy2.Enabled = false;
            this.Multipy2.Location = new System.Drawing.Point(263, 141);
            this.Multipy2.Name = "Multipy2";
            this.Multipy2.Size = new System.Drawing.Size(71, 23);
            this.Multipy2.TabIndex = 15;
            this.Multipy2.Text = "Wybierz";
            this.Multipy2.UseVisualStyleBackColor = true;
            this.Multipy2.Click += new System.EventHandler(this.Multipy2_Click);
            // 
            // Multipy1
            // 
            this.Multipy1.Enabled = false;
            this.Multipy1.Location = new System.Drawing.Point(157, 141);
            this.Multipy1.Name = "Multipy1";
            this.Multipy1.Size = new System.Drawing.Size(71, 23);
            this.Multipy1.TabIndex = 14;
            this.Multipy1.Text = "Wybierz";
            this.Multipy1.UseVisualStyleBackColor = true;
            this.Multipy1.Click += new System.EventHandler(this.Multipy1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(242, 181);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(11, 13);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Div2
            // 
            this.Div2.Enabled = false;
            this.Div2.Location = new System.Drawing.Point(263, 177);
            this.Div2.Name = "Div2";
            this.Div2.Size = new System.Drawing.Size(71, 23);
            this.Div2.TabIndex = 18;
            this.Div2.Text = "Wybierz";
            this.Div2.UseVisualStyleBackColor = true;
            this.Div2.Click += new System.EventHandler(this.Div2_Click);
            // 
            // Div1
            // 
            this.Div1.Enabled = false;
            this.Div1.Location = new System.Drawing.Point(157, 177);
            this.Div1.Name = "Div1";
            this.Div1.Size = new System.Drawing.Size(71, 23);
            this.Div1.TabIndex = 17;
            this.Div1.Text = "Wybierz";
            this.Div1.UseVisualStyleBackColor = true;
            this.Div1.Click += new System.EventHandler(this.Div1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(236, 218);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(20, 13);
            this.textBox6.TabIndex = 22;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Mod2
            // 
            this.Mod2.Enabled = false;
            this.Mod2.Location = new System.Drawing.Point(263, 213);
            this.Mod2.Name = "Mod2";
            this.Mod2.Size = new System.Drawing.Size(71, 23);
            this.Mod2.TabIndex = 21;
            this.Mod2.Text = "Wybierz";
            this.Mod2.UseVisualStyleBackColor = true;
            this.Mod2.Click += new System.EventHandler(this.Mod2_Click);
            // 
            // Mod1
            // 
            this.Mod1.Enabled = false;
            this.Mod1.Location = new System.Drawing.Point(157, 213);
            this.Mod1.Name = "Mod1";
            this.Mod1.Size = new System.Drawing.Size(71, 23);
            this.Mod1.TabIndex = 20;
            this.Mod1.Text = "Wybierz";
            this.Mod1.UseVisualStyleBackColor = true;
            this.Mod1.Click += new System.EventHandler(this.Mod1_Click);
            // 
            // OnNumer
            // 
            this.OnNumer.Enabled = false;
            this.OnNumer.Location = new System.Drawing.Point(157, 288);
            this.OnNumer.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            this.OnNumer.Minimum = new decimal(new int[] { 5000000, 0, 0, -2147483648 });
            this.OnNumer.Name = "OnNumer";
            this.OnNumer.Size = new System.Drawing.Size(175, 20);
            this.OnNumer.TabIndex = 24;
            this.OnNumer.ValueChanged += new System.EventHandler(this.OnNumer_ValueChanged);
            // 
            // Add1
            // 
            this.Add1.Enabled = false;
            this.Add1.Location = new System.Drawing.Point(157, 69);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(71, 23);
            this.Add1.TabIndex = 25;
            this.Add1.Text = "Wybierz";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // Add2
            // 
            this.Add2.Enabled = false;
            this.Add2.Location = new System.Drawing.Point(263, 68);
            this.Add2.Name = "Add2";
            this.Add2.Size = new System.Drawing.Size(71, 23);
            this.Add2.TabIndex = 26;
            this.Add2.Text = "Wybierz";
            this.Add2.UseVisualStyleBackColor = true;
            this.Add2.Click += new System.EventHandler(this.Add2_Click);
            // 
            // OnVar
            // 
            this.OnVar.Enabled = false;
            this.OnVar.FormattingEnabled = true;
            this.OnVar.Location = new System.Drawing.Point(157, 251);
            this.OnVar.Name = "OnVar";
            this.OnVar.Size = new System.Drawing.Size(175, 21);
            this.OnVar.TabIndex = 27;
            this.OnVar.Click += new System.EventHandler(this.OnVar_Clicked);
            // 
            // Ok
            // 
            this.Ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ok.Location = new System.Drawing.Point(161, 320);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(95, 27);
            this.Ok.TabIndex = 30;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // ChoosseVarOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 359);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.OnVar);
            this.Controls.Add(this.Add2);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.OnNumer);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Mod2);
            this.Controls.Add(this.Mod1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Div2);
            this.Controls.Add(this.Div1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Multipy2);
            this.Controls.Add(this.Multipy1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Sub2);
            this.Controls.Add(this.Sub1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OnNumberRadio);
            this.Controls.Add(this.OnVarRadio);
            this.Controls.Add(this.ModRadio);
            this.Controls.Add(this.DivRadio);
            this.Controls.Add(this.MultipyRadio);
            this.Controls.Add(this.SubRadio);
            this.Controls.Add(this.AddRadio);
            this.Controls.Add(this.textBox1);
            this.Name = "ChoosseVarOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.OnNumer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Ok;

        private System.Windows.Forms.ComboBox OnVar;

        private System.Windows.Forms.NumericUpDown OnNumer;

        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.Button Add2;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Sub2;
        private System.Windows.Forms.Button Sub1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Multipy2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Div2;
        private System.Windows.Forms.Button Div1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Mod2;
        private System.Windows.Forms.Button Mod1;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button Multipy1;
        

        private System.Windows.Forms.RadioButton OnVarRadio;
        private System.Windows.Forms.RadioButton OnNumberRadio;

        private System.Windows.Forms.RadioButton MultipyRadio;
        private System.Windows.Forms.RadioButton DivRadio;
        private System.Windows.Forms.RadioButton ModRadio;

        private System.Windows.Forms.RadioButton AddRadio;
        private System.Windows.Forms.RadioButton SubRadio;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}