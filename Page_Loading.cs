using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Private_Chat
{
	public partial class Page_Loading : Form
	{
		public Page_Loading()
		{
			InitializeComponent();

			this.FormBorderStyle = FormBorderStyle.None;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.TopMost = true;
		}
		public void AggiornaStato()
		{
			Application.DoEvents();
		}
	}
}
