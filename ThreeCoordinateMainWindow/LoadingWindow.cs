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
	public partial class LoadingWindow : Form
	{
		public LoadingWindow()
		{
			InitializeComponent();
		}

		public void SetProgressBarValue(int input)
		{
			pbProgress.Value = input;
		}

		public void SetText(string input)
		{
			msg_Progress.Text = input;
		}
	}
}
