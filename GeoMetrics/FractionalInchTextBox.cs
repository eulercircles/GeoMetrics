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

		public ImperialDenominators Denominator { get; set; }

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
					Text = parsedValue.Value.ToFractionalInchString();
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
