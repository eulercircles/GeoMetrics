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

			textBox_ALength.Text = "---";
			textBox_BLength.Text = "---";
			textBox_Angle.Text = "---";
		}

		private void FractionalInchTextBox_Leave(object sender, EventArgs e)
		{
			var axValue = fractionalInchTextBox_AX.GetRawValue();
			var ayValue = fractionalInchTextBox_AY.GetRawValue();
			var azValue = fractionalInchTextBox_AZ.GetRawValue();

			var bxValue = fractionalInchTextBox_BX.GetRawValue();
			var byValue = fractionalInchTextBox_BY.GetRawValue();
			var bzValue = fractionalInchTextBox_BZ.GetRawValue();

			Nullable<Vector3> vectorA = null;
			Nullable<Vector3> vectorB = null;
			Nullable<CustomaryLength> vectorAMeasure = null;
			Nullable<CustomaryLength> vectorBMeasure = null;

			if (axValue.HasValue && ayValue.HasValue && azValue.HasValue)
			{
				vectorA = new Vector3((float)axValue.Value, (float)ayValue.Value, (float)azValue.Value);
				vectorAMeasure = new CustomaryLength(vectorA.Value.Length());
				textBox_ALength.Text = vectorAMeasure.Value.ToFractionalInchString(CustomaryDenominators.ThirtySecond);
			}
			else { textBox_ALength.Text = "---"; }

			if (bxValue.HasValue && byValue.HasValue && bzValue.HasValue)
			{
				vectorB = new Vector3((float)bxValue.Value, (float)byValue.Value, (float)bzValue.Value);
				vectorBMeasure = new CustomaryLength(vectorB.Value.Length());
				textBox_BLength.Text = vectorBMeasure.Value.ToFractionalInchString(CustomaryDenominators.ThirtySecond);
			}
			else { textBox_BLength.Text = "---"; }

			if (vectorA.HasValue && vectorB.HasValue && vectorAMeasure.HasValue && vectorBMeasure.HasValue)
			{
				var dot = Vector3.Dot(vectorA.Value, vectorB.Value);
				var length = (vectorA.Value.Length() * vectorB.Value.Length());

				var angleMeasure = Math.Acos(dot / length);
				textBox_Angle.Text = $"{Math.Round(angleMeasure, 1, MidpointRounding.AwayFromZero)}°";
			}
			else { textBox_Angle.Text = "---"; }
		}
	}
}
