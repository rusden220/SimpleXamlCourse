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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly Button _buttonTest;

		public MainWindow()
		{
			InitializeComponent();
			_buttonTest = new Button();
			_buttonTest.Width = 100;
			_buttonTest.Height = 100;
			_buttonTest.Name = nameof(buttonTest);
			_buttonTest.Content = "fuck off";
			layoutGrid.Children.Add(_buttonTest);

			var buttonTest1 = new Button();
			buttonTest1.Width = 60;
			buttonTest1.Height = 60;
			buttonTest1.Name = nameof(buttonTest);
			buttonTest1.Content = "fuck off";
			layoutGrid.Children.Add(buttonTest1);
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var result = this.FindName("buttonTest");
			var button = (Button)this.FindName(nameof(buttonTest));
			button.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);

		}
	}
}
