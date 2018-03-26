using System;
using System.Windows.Forms;

using System.Numerics;

using FlintLib.Geometrics;
using FlintLib.Mathematics;

namespace GeoMetrics
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			textBox_3dAngle_ALength.Text = "---";
			textBox_3dAngle_BLength.Text = "---";
			textBox_3dAngle_Angle.Text = "---";
		}

		private void FractionalInchTextBox_3dAngle_Leave(object sender, EventArgs e)
		{
			var axValue = fractionalInchTextBox_3dAngle_AX.GetRawValue();
			var ayValue = fractionalInchTextBox_3dAngle_AY.GetRawValue();
			var azValue = fractionalInchTextBox_3dAngle_AZ.GetRawValue();

			var bxValue = fractionalInchTextBox_3dAngle_BX.GetRawValue();
			var byValue = fractionalInchTextBox_3dAngle_BY.GetRawValue();
			var bzValue = fractionalInchTextBox_3dAngle_BZ.GetRawValue();

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
			else { textBox_3dAngle_ALength.Text = "---"; }

			if (bxValue.HasValue && byValue.HasValue && bzValue.HasValue)
			{
				vectorB = new Vector3((float)bxValue.Value, (float)byValue.Value, (float)bzValue.Value);
				vectorBMeasure = new CustomaryLength(vectorB.Value.Length());
				textBox_BLength.Text = vectorBMeasure.Value.ToFractionalInchString(CustomaryDenominators.ThirtySecond);
			}
			else { textBox_3dAngle_BLength.Text = "---"; }

			if (vectorA.HasValue && vectorB.HasValue && vectorAMeasure.HasValue && vectorBMeasure.HasValue)
			{
				var angleMeasure = Functions.DegreeAngle(vectorA.Value, vectorB.Value);
				textBox_3dAngle_Angle.Text = $"{Math.Round(angleMeasure, 1, MidpointRounding.AwayFromZero)}°";
			}
			else { textBox_3dAngle_Angle.Text = "---"; }
		}
	}
}
