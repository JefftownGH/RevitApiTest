using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace WpfDisplay
{
	public partial class MainWindow : Window
	{
		List<Data> dataList = new List<Data>();
		public MainWindow()
		{
			Assembly.LoadFrom(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MaterialDesignThemes.Wpf.dll"));
			Assembly.LoadFrom(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MaterialDesignColors.dll"));
						
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
		private void loggerButton_Click(object sender, RoutedEventArgs e)
		{
			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Debug()
				.WriteTo.File("Logs\\ButtonLog.txt", rollingInterval: RollingInterval.Day)
				.CreateLogger();

			Log.Information("Hello, world!");

			int a = 10, b = 0;
			try
			{
				Log.Debug("Dividing {A} by {B}", a, b);
				MessageBox.Show("Log created");
			}
			catch (Exception ex)
			{
				Log.Error(ex, "Something went wrong");
			}
			Log.CloseAndFlush();
		}
	}
}
