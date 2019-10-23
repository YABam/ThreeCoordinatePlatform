using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeCoordinateMainWindow
{
	public partial class Buy : Form
	{
		public Buy()
		{
			InitializeComponent();
			picAliPay.Image = AliPay.alipay;
		}
	}
}
