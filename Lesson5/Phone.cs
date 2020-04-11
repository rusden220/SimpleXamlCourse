using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls.Primitives;

namespace Lesson5
{
	public class Phone: DependencyObject
	{
		public static readonly DependencyProperty TitleProperty;
		public static readonly DependencyProperty PriceProperty;

		static Phone()
		{
			var metadata = new FrameworkPropertyMetadata();
			metadata.CoerceValueCallback += new CoerceValueCallback(CoerceMaximum);
			TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Phone));
			PriceProperty = DependencyProperty.Register("Price", typeof(int), typeof(Phone), metadata, IsInputCorrect);
			
		}

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}
		public int Price
		{
			get { return (int)GetValue(PriceProperty); }
			set { SetValue(PriceProperty, value); }
		}

		private static bool IsInputCorrect(object value)
		{
			Debug.WriteLine($"ValidateValueCallback: {value.ToString()}");			
			return (value is int) && (value as int?).Value >= 0;
		}

		private static object CoerceMaximum(DependencyObject dpObj, object value)
		{
			Debug.WriteLine($"CoerceValueCallback: {value.ToString()}, {dpObj.ToString()}");
			int currentValue = (int)value;
			if (currentValue < 1) 
				return 1;

			if (currentValue > 1000)
				return 1000;

			return currentValue;
		}
	}
}
