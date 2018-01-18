using System;
using System.Windows.Forms;

using System.Numerics;

using FlintLib.Geometrics;

namespace GeoMetrics
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void FractionalInchTextBoxA_Leave(object sender, EventArgs e)
		{
			var xValue = fractionalInchTextBox_AX.GetRawValue();
			var yValue = fractionalInchTextBox_AY.GetRawValue();
			var zValue = fractionalInchTextBox_AZ.GetRawValue();

			if (xValue.HasValue && yValue.HasValue && zValue.HasValue)
			{
				var vector = new Vector3((float)xValue.Value, (float)yValue.Value, (float)zValue.Value);

				var measure = new ImperialMeasure(vector.Length());
				textBox_ALength.Text = measure.ToFractionalInchString(ImperialDenominators.ThirtySecond);
			}
		}

		private void FractionalInchTextBoxB_Leave(object sender, EventArgs e)
		{
			var xValue = fractionalInchTextBox_BX.GetRawValue();
			var yValue = fractionalInchTextBox_BY.GetRawValue();
			var zValue = fractionalInchTextBox_BZ.GetRawValue();

			if (xValue.HasValue && yValue.HasValue && zValue.HasValue)
			{
				var vector = new Vector3((float)xValue.Value, (float)yValue.Value, (float)zValue.Value);

				var measure = new ImperialMeasure(vector.Length());
				textBox_BLength.Text = measure.ToFractionalInchString(ImperialDenominators.ThirtySecond);
			}
		}
	}
}
