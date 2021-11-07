
namespace Odev_1
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
            this.radioMeyve = new System.Windows.Forms.RadioButton();
            this.radioSebze = new System.Windows.Forms.RadioButton();
            this.comboMeyve = new System.Windows.Forms.ComboBox();
            this.comboSebze = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioMeyve
            // 
            this.radioMeyve.AutoSize = true;
            this.radioMeyve.Location = new System.Drawing.Point(12, 12);
            this.radioMeyve.Name = "radioMeyve";
            this.radioMeyve.Size = new System.Drawing.Size(60, 19);
            this.radioMeyve.TabIndex = 4;
            this.radioMeyve.TabStop = true;
            this.radioMeyve.Text = "Meyve";
            this.radioMeyve.UseVisualStyleBackColor = true;
            this.radioMeyve.CheckedChanged += new System.EventHandler(this.radioMeyve_CheckedChanged);
            // 
            // radioSebze
            // 
            this.radioSebze.AutoSize = true;
            this.radioSebze.Location = new System.Drawing.Point(12, 49);
            this.radioSebze.Name = "radioSebze";
            this.radioSebze.Size = new System.Drawing.Size(55, 19);
            this.radioSebze.TabIndex = 0;
            this.radioSebze.TabStop = true;
            this.radioSebze.Text = "Sebze";
            this.radioSebze.UseVisualStyleBackColor = true;
            this.radioSebze.CheckedChanged += new System.EventHandler(this.radioSebze_CheckedChanged);
            // 
            // comboMeyve
            // 
            this.comboMeyve.FormattingEnabled = true;
            this.comboMeyve.Items.AddRange(new object[] {
            "Elma",
            "Armut",
            "Portakal",
            "Üzüm"});
            this.comboMeyve.Location = new System.Drawing.Point(113, 11);
            this.comboMeyve.Name = "comboMeyve";
            this.comboMeyve.Size = new System.Drawing.Size(182, 23);
            this.comboMeyve.TabIndex = 1;
            this.comboMeyve.Visible = false;
            // 
            // comboSebze
            // 
            this.comboSebze.FormattingEnabled = true;
            this.comboSebze.Items.AddRange(new object[] {
            "Patlıcan",
            "Havuç",
            "Kabak",
            "Limon"});
            this.comboSebze.Location = new System.Drawing.Point(113, 48);
            this.comboSebze.Name = "comboSebze";
            this.comboSebze.Size = new System.Drawing.Size(182, 23);
            this.comboSebze.TabIndex = 1;
            this.comboSebze.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miktar";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(113, 92);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(182, 23);
            this.txtMiktar.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(12, 129);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(284, 48);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 516);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSebze);
            this.Controls.Add(this.comboMeyve);
            this.Controls.Add(this.radioSebze);
            this.Controls.Add(this.radioMeyve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMeyve;
        private System.Windows.Forms.RadioButton radioSebze;
        private System.Windows.Forms.ComboBox comboMeyve;
        private System.Windows.Forms.ComboBox comboSebze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnHesapla;
    }
}

