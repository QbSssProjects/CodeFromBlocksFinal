namespace WindowsFormsApp2
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
            this.newVar = new System.Windows.Forms.Button();
            this.setvar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.If = new System.Windows.Forms.Button();
            this.For = new System.Windows.Forms.Button();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.print = new System.Windows.Forms.Button();
            this.ifElse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endIf = new System.Windows.Forms.Button();
            this.While = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.Kompiluj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newVar
            // 
            this.newVar.Location = new System.Drawing.Point(12, 113);
            this.newVar.Name = "newVar";
            this.newVar.Size = new System.Drawing.Size(161, 25);
            this.newVar.TabIndex = 0;
            this.newVar.Text = "Nowa zmienna";
            this.newVar.UseVisualStyleBackColor = true;
            this.newVar.Click += new System.EventHandler(this.newVar_Click);
            // 
            // setvar
            // 
            this.setvar.Location = new System.Drawing.Point(12, 142);
            this.setvar.Name = "setvar";
            this.setvar.Size = new System.Drawing.Size(161, 25);
            this.setvar.TabIndex = 1;
            this.setvar.Text = "Ustaw zmienna";
            this.setvar.UseVisualStyleBackColor = true;
            this.setvar.Click += new System.EventHandler(this.setvar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AllowPromptAsInput = false;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 96);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.Text = "Zmienne";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.AllowPromptAsInput = false;
            this.maskedTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox3.Location = new System.Drawing.Point(12, 173);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox3.TabIndex = 10;
            this.maskedTextBox3.Text = "Warunki";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // If
            // 
            this.If.Location = new System.Drawing.Point(12, 192);
            this.If.Name = "If";
            this.If.Size = new System.Drawing.Size(161, 25);
            this.If.TabIndex = 11;
            this.If.Text = "Jeśli";
            this.If.UseVisualStyleBackColor = true;
            this.If.Click += new System.EventHandler(this.If_Click);
            // 
            // For
            // 
            this.For.Location = new System.Drawing.Point(12, 301);
            this.For.Name = "For";
            this.For.Size = new System.Drawing.Size(161, 25);
            this.For.TabIndex = 12;
            this.For.Text = "Wykonaj x razy";
            this.For.UseVisualStyleBackColor = true;
            this.For.Click += new System.EventHandler(this.For_Click);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.AllowPromptAsInput = false;
            this.maskedTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox4.Location = new System.Drawing.Point(12, 363);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.ReadOnly = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox4.TabIndex = 16;
            this.maskedTextBox4.Text = "Wejścia / Wyjścia";
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(12, 382);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(161, 25);
            this.print.TabIndex = 17;
            this.print.Text = "Wypisz na ekranie";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // ifElse
            // 
            this.ifElse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ifElse.Location = new System.Drawing.Point(12, 251);
            this.ifElse.Name = "ifElse";
            this.ifElse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ifElse.Size = new System.Drawing.Size(161, 25);
            this.ifElse.TabIndex = 22;
            this.ifElse.Text = "Jeśli / W przeciwnym wypadku";
            this.ifElse.UseVisualStyleBackColor = true;
            this.ifElse.Click += new System.EventHandler(this.ifElse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.endIf);
            this.panel1.Controls.Add(this.While);
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.ifElse);
            this.panel1.Controls.Add(this.print);
            this.panel1.Controls.Add(this.maskedTextBox4);
            this.panel1.Controls.Add(this.For);
            this.panel1.Controls.Add(this.If);
            this.panel1.Controls.Add(this.maskedTextBox3);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.setvar);
            this.panel1.Controls.Add(this.newVar);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 734);
            this.panel1.TabIndex = 24;
            // 
            // endIf
            // 
            this.endIf.Location = new System.Drawing.Point(12, 223);
            this.endIf.Name = "endIf";
            this.endIf.Size = new System.Drawing.Size(161, 25);
            this.endIf.TabIndex = 26;
            this.endIf.Text = "Zakończenie Warunku Jeśli";
            this.endIf.UseVisualStyleBackColor = true;
            this.endIf.Click += new System.EventHandler(this.endIf_Click);
            // 
            // While
            // 
            this.While.Location = new System.Drawing.Point(12, 332);
            this.While.Name = "While";
            this.While.Size = new System.Drawing.Size(161, 25);
            this.While.TabIndex = 25;
            this.While.Text = "Wykonuj dopóki";
            this.While.UseVisualStyleBackColor = true;
            this.While.Click += new System.EventHandler(this.While_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.AllowPromptAsInput = false;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Location = new System.Drawing.Point(12, 282);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(161, 13);
            this.maskedTextBox2.TabIndex = 24;
            this.maskedTextBox2.Text = "Pętle";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Location = new System.Drawing.Point(488, 30);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(283, 30);
            this.Start.TabIndex = 23;
            this.Start.Text = "POCZĄTEK";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kompiluj
            // 
            this.Kompiluj.Location = new System.Drawing.Point(985, 3);
            this.Kompiluj.Name = "Kompiluj";
            this.Kompiluj.Size = new System.Drawing.Size(67, 31);
            this.Kompiluj.TabIndex = 25;
            this.Kompiluj.Text = "Kompiluj";
            this.Kompiluj.UseVisualStyleBackColor = true;
            this.Kompiluj.Click += new System.EventHandler(this.Kompiluj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.Kompiluj);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(1080, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Kompiluj;

        private System.Windows.Forms.Button endIf;

        private System.Windows.Forms.ContextMenu contextMenu1;

        private System.Windows.Forms.Button While;

        private System.Windows.Forms.Button Start;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button ifElse;

        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Button print;

        private System.Windows.Forms.Button For;
        private System.Windows.Forms.Button If;

        private System.Windows.Forms.MaskedTextBox maskedTextBox3;

        private System.Windows.Forms.MaskedTextBox maskedTextBox2;

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

        private System.Windows.Forms.Button newVar;
        private System.Windows.Forms.Button setvar;

        #endregion
    }
}