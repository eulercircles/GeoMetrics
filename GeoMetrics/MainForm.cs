using System;

using System.Windows.Forms;

using System.Numerics;

namespace GeoMetrics
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void NumericInput_TextChanged(object sender, EventArgs e)
		{
			if (sender != null && sender is FractionalInchTextBox)
			{
				var numericInput = sender as FractionalInchTextBox;

				
			}
		}
	}
}
