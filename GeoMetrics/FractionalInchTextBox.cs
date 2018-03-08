using System;
using System.Drawing;
using System.Windows.Forms;

using FlintLib.Common;
using FlintLib.Geometrics;

namespace GeoMetrics
{
	public class FractionalInchTextBox : TextBox
	{
		private readonly Font _normalFont;
		private readonly Font _errorFont;

		private ImperialDenominators _denominator = ImperialDenominators.HundredTwentyEighth;
		public ImperialDenominators Denominator
		{
			get { return _denominator; }
			set { _denominator = value; }
		}

		public FractionalInchTextBox()
		{
			_normalFont = Font;

			_errorFont = new Font(_normalFont, FontStyle.Bold);

			BackColor = Colors.NeutralBackground;
			ForeColor = Colors.NeutralForeground;

			TextAlign = HorizontalAlignment.Right;

			TextChanged += HandleTextChanged;
			GotFocus += HandleGotFocus;
			LostFocus += HandleLostFocus;
		}

		public double? GetRawValue()
		{
			if (ImperialMeasure.TryParse(Text, out ImperialMeasure? result))
			{
				return result.Value.DecimalInches;
			}
			else { return null; }
		}

		private void HandleGotFocus(object sender, EventArgs e)
		{

		}

		private void HandleLostFocus(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(Text))
			{
				ImperialMeasure.TryParse(Text, out ImperialMeasure? parsedValue);
				if (parsedValue.HasValue)
				{
					Text = parsedValue.Value.ToFractionalInchString(_denominator);
					Font = _normalFont;
					BackColor = Colors.GoodBackground;
					ForeColor = Colors.GoodForeground;
				}
				else
				{
					Font = _errorFont;
					BackColor = Colors.BadBackground;
					ForeColor = Colors.BadForeground;
				}
			}
			else
			{
				Font = _normalFont;
				BackColor = Colors.NeutralBackground;
				ForeColor = Colors.NeutralForeground;
			}
		}

		private void HandleTextChanged(object sender, EventArgs e)
		{

		}
	}
}
