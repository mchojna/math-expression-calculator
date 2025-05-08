using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.View
{
    internal interface ICalculatorView
    {
        string Display { get; set; }
        DataGridViewSelectedRowCollection SelectedRows { get; }

        event EventHandler<string> KeyEvent;
        event EventHandler EqualEvent;
        event EventHandler ClearEvent;
        event EventHandler DeleteEvent;

        event EventHandler CalculateFromAFileEvent;
        event EventHandler ExportToAFileEvent;

        event EventHandler OpenHistoryEvent;

        event EventHandler DeleteSelectedRowsEvent;
        void SetEquationBindingSource(BindingSource equationList);
    }
}
