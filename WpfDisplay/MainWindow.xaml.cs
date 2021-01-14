using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfDisplay
{
	public partial class MainWindow : Window
	{
		List<Data> dataList = new List<Data>();
		public MainWindow()
		{
			Assembly.LoadFrom(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MaterialDesignThemes.Wpf.dll"));
			Assembly.LoadFrom(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MaterialDesignColors.dll"));

			/*ColorZoneAssist.SetMode(new CheckBox(), ColorZoneMode.Accent);
			Hue hue = new Hue("xyz", System.Windows.Media.Color.FromArgb(1, 2, 3, 4), System.Windows.Media.Color.FromArgb(1, 5, 6, 7));
*/
			InitializeComponent();
		}
		public void LoadData(List<Data> dataList)
		{
			this.dataList = dataList;
			dataGrid.ItemsSource = dataList;
		}

		private void filter_Button(object sender, RoutedEventArgs e)
		{			
			List<Data> newData = new List<Data>();
			foreach (Data el in dataList)
			{
				if (el.Name.Equals(textBox.Text) || el.Id.ToString().Equals(textBox.Text) )
				{					
					newData.Add(new Data() { Name = el.Name, Id = el.Id });
					dataGrid.ItemsSource = null;
					dataGrid.Items.Clear();
					dataGrid.ItemsSource = newData;
				}
			}
			if (!dataList.Any(x => x.Name == textBox.Text) && !dataList.Any(x=>x.Id.ToString()==textBox.Text))
			{
				MessageBox.Show("Element not definded");
			}
		}

		private void showAll_Button(object sender, RoutedEventArgs e)
		{
			LoadData(dataList);
		}
	}
}
