using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using WpfDisplay;

namespace RevitTest
/*
 * Using .NET 4. * and above framework build and extension for Autodesk Revit,
 * you can refer to https://www.revitapidocs.com/ for the refences.

Given Scenario after plugin loaded to Autodesk Revit it should collect all
the elements from the model of the rvt file (you can use any file or even default models given.)
and display name those elements name and GUID in the grid view.
(Note that all elements information should be taken only from rvt model).
User should be able to filter out specific element using name or GUID.
In case of not found name or GUID, appropriate message should be provided to user. 
Please send your answer as open repo on any Git based platform

Нужно создать плагин для Revit чтобы он при нажатие считал все элементы модели с файла и показать
их на для пользователя в табличном виде, также пользы должен отфильтровать по GUID или же наименованию.
При случаях, когда элемент не найдет в таблице нужно показать 
диалоговое окно с уведомлением о том такого элемента в модели не существует. 
Для выполнения задание можно использовать любую версию .net 4. * framework.
После выполнение задание нужно будет его выложить на любой GIT с открытым доступом
для ознакомления ответ может отправлен ввиду ссылки на репозитории. 

 */
{
	[Transaction(TransactionMode.Manual)]
	[Regeneration(RegenerationOption.Manual)]
	public class Class1 : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{
			UIApplication uiapp = commandData.Application;
			Document doc = uiapp.ActiveUIDocument.Document;

			FilteredElementCollector collection = 
			    new FilteredElementCollector(doc, doc.ActiveView.Id);			    
						
			List<Data> dataList = new List<Data>();
			string allNameElements = null;
			try
			{
				foreach (Element elem in collection)
				{
					dataList.Add(new Data()
					{
						Name = elem.Name,
						Id = elem.VersionGuid
					});				
				}
				MainWindow myWindow = new MainWindow();
				myWindow.LoadData(dataList);
				myWindow.Show();
			}
			catch (Exception ex)
			{
				message = ex.Message;
				return Result.Failed;
			}			

			return Result.Succeeded;
		}
	}
}
