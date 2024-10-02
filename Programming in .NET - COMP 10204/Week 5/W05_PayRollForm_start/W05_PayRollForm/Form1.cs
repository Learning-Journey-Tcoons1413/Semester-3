using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// Application to simulate A Payroll system in a company with different types of Employees 
/// Uses a model view architecture where the model is represented by a List of Employees
/// 
/// Topics covered:
/// o  Polymorphic behavior in the model
/// o  Model - View 
/// o  Use of customized set/get - see subclasses of Employee
/// o  Persistance of the model to a text file 
/// o  Re-creation of the model from a text file 
/// o  Use of standard File Dialogs for the selection of the text file source
/// 
/// </summary>


namespace PayRollForm
{
    public partial class FormPayrollSystem : Form
    {

        public FormPayrollSystem()
        {
            InitializeComponent();
        }
    }
}
