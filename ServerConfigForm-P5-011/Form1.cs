using ServiceMtk_P1_20190140011;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_011
{
	public partial class Form1 : Form
	{
		private ServiceHost Host;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonOn_Click(object sender, EventArgs e)
		{
			Host = new ServiceHost(typeof(Matematika));

			labelKet.Text = "Server ON";
			labelOnOrOff.Text = "Klik OFF untuk Mematikan Server";
			Host.Open();
			buttonOn.Enabled = false;
			buttonOff.Enabled = true;
		}

		private void buttonOff_Click(object sender, EventArgs e)
		{
			buttonOn.Enabled = true;
			buttonOff.Enabled = false;
			Host.Close();
			labelOnOrOff.Text = "klik ON untuk Menjalankan Server";
			labelKet.Text = "Server OFF";
		}
	}
}
