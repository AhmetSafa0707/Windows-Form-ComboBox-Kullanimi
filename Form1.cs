using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_ComboBox_Kullanımı
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{	
			combo_Icecekler.Items.Add("Gazoz");
			combo_Icecekler.Items.Add("Maden Suyu");

			combo_Icecekler.Items.RemoveAt(4);// RemoveAt metodu index numarasını baz alır.
			combo_Icecekler.Items.Remove("Su"); // Remove metodu ise direkt indexi baz alır.

		}

		private void btn_gunSec_Click(object sender, EventArgs e)
		{
			string secilenIcecek=combo_Icecekler.SelectedItem.ToString();

			MessageBox.Show("Seçtiğiniz İçecek: " + secilenIcecek);
		}
	}
}
