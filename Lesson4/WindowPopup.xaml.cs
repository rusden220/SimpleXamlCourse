using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lesson4
{
	/// <summary>
	/// Interaction logic for WindowPopup.xaml
	/// </summary>
	public partial class WindowPopup : Window
	{
		public WindowPopup()
		{
			InitializeComponent();
		}

		private void Button_MouseEnter_1(object sender, MouseEventArgs e)
		{
			popup1.IsOpen = true;
		}
	}
}
