namespace Windows_Form_ComboBox_Kullanımı
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.combo_Icecekler = new System.Windows.Forms.ComboBox();
			this.btn_gunSec = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// combo_Icecekler
			// 
			this.combo_Icecekler.BackColor = System.Drawing.Color.Yellow;
			this.combo_Icecekler.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.combo_Icecekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.combo_Icecekler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.combo_Icecekler.FormattingEnabled = true;
			this.combo_Icecekler.Items.AddRange(new object[] {
            "Çay",
            "Kahve",
            "Milk Shake",
            "Soğuk Çay",
            "Su"});
			this.combo_Icecekler.Location = new System.Drawing.Point(24, 31);
			this.combo_Icecekler.Name = "combo_Icecekler";
			this.combo_Icecekler.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.combo_Icecekler.Size = new System.Drawing.Size(368, 48);
			this.combo_Icecekler.Sorted = true;
			this.combo_Icecekler.TabIndex = 0;
			this.combo_Icecekler.Text = "İçecekler";
			this.combo_Icecekler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btn_gunSec
			// 
			this.btn_gunSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_gunSec.Location = new System.Drawing.Point(24, 117);
			this.btn_gunSec.Name = "btn_gunSec";
			this.btn_gunSec.Size = new System.Drawing.Size(368, 76);
			this.btn_gunSec.TabIndex = 1;
			this.btn_gunSec.Text = "İçecek Seçiniz";
			this.btn_gunSec.UseVisualStyleBackColor = true;
			this.btn_gunSec.Click += new System.EventHandler(this.btn_gunSec_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 437);
			this.Controls.Add(this.btn_gunSec);
			this.Controls.Add(this.combo_Icecekler);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox combo_Icecekler;
		private System.Windows.Forms.Button btn_gunSec;
	}
}

