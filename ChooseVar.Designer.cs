using System.ComponentModel;

namespace WindowsFormsApp2
{
    partial class ChooseVar
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
            this.comboBoxChooseVar = new System.Windows.Forms.ComboBox();
            this.ZmiennaRadioBox = new System.Windows.Forms.RadioButton();
            this.NumberRadio = new System.Windows.Forms.RadioButton();
            this.ChooseNumber = new System.Windows.Forms.NumericUpDown();
            this.OkChooseVar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChooseVar
            // 
            this.comboBoxChooseVar.Enabled = false;
            this.comboBoxChooseVar.FormattingEnabled = true;
            this.comboBoxChooseVar.Location = new System.Drawing.Point(97, 34);
            this.comboBoxChooseVar.Name = "comboBoxChooseVar";
            this.comboBoxChooseVar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseVar.TabIndex = 1;
            this.comboBoxChooseVar.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseVar_SelectedIndexChanged);
            // 
            // ZmiennaRadioBox
            // 
            this.ZmiennaRadioBox.Location = new System.Drawing.Point(12, 34);
            this.ZmiennaRadioBox.Name = "ZmiennaRadioBox";
            this.ZmiennaRadioBox.Size = new System.Drawing.Size(68, 24);
            this.ZmiennaRadioBox.TabIndex = 2;
            this.ZmiennaRadioBox.TabStop = true;
            this.ZmiennaRadioBox.Text = "Zmienna";
            this.ZmiennaRadioBox.UseVisualStyleBackColor = true;
            this.ZmiennaRadioBox.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NumberRadio
            // 
            this.NumberRadio.Location = new System.Drawing.Point(12, 64);
            this.NumberRadio.Name = "NumberRadio";
            this.NumberRadio.Size = new System.Drawing.Size(104, 24);
            this.NumberRadio.TabIndex = 3;
            this.NumberRadio.TabStop = true;
            this.NumberRadio.Text = "Liczba";
            this.NumberRadio.UseVisualStyleBackColor = true;
            this.NumberRadio.CheckedChanged += new System.EventHandler(this.NumberRadio_CheckedChanged);
            // 
            // ChooseNumber
            // 
            this.ChooseNumber.Enabled = false;
            this.ChooseNumber.Location = new System.Drawing.Point(97, 64);
            this.ChooseNumber.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            this.ChooseNumber.Minimum = new decimal(new int[] { 5000000, 0, 0, -2147483648 });
            this.ChooseNumber.Name = "ChooseNumber";
            this.ChooseNumber.Size = new System.Drawing.Size(121, 20);
            this.ChooseNumber.TabIndex = 25;
            this.ChooseNumber.ValueChanged += new System.EventHandler(this.ChooseNumber_ValueChanged);
            // 
            // OkChooseVar
            // 
            this.OkChooseVar.Location = new System.Drawing.Point(97, 96);
            this.OkChooseVar.Name = "OkChooseVar";
            this.OkChooseVar.Size = new System.Drawing.Size(75, 23);
            this.OkChooseVar.TabIndex = 26;
            this.OkChooseVar.Text = "Ok";
            this.OkChooseVar.UseVisualStyleBackColor = true;
            this.OkChooseVar.Click += new System.EventHandler(this.OkChooseVar_Click);
            // 
            // ChooseVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 131);
            this.Controls.Add(this.OkChooseVar);
            this.Controls.Add(this.ChooseNumber);
            this.Controls.Add(this.NumberRadio);
            this.Controls.Add(this.ZmiennaRadioBox);
            this.Controls.Add(this.comboBoxChooseVar);
            this.Name = "ChooseVar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybierz Zmienną";
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNumber)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button OkChooseVar;

        private System.Windows.Forms.NumericUpDown ChooseNumber;

        private System.Windows.Forms.RadioButton NumberRadio;

        private System.Windows.Forms.RadioButton ZmiennaRadioBox;

        private System.Windows.Forms.ComboBox comboBoxChooseVar;

        #endregion
    }
}