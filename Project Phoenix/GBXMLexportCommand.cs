using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Application = Autodesk.Revit.ApplicationServices.Application;

namespace Project_Phoenix
{
    // add transaction attributes
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]

    public class GBXMLexportCommand : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData, 
            ref string message, 
            ElementSet elements)
        {
            TaskDialog.Show("Revit", "Hello World");

            return Result.Failed;
        }
    }
}
