using Calculator.Data;
using Calculator.Model;
using Calculator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Presenter
{
    internal class CalculatorPresenter
    {
        private CalculatorView view;
        private CalculatorModel model;

        private BindingSource equationBindingSource;
        private IEnumerable<EquationModel> equationList;

        private string? result;

        public CalculatorPresenter(CalculatorView view)
        {
            this.view = view;
            model = new CalculatorModel();

            equationBindingSource = new BindingSource();
            view.SetEquationBindingSource(equationBindingSource);
            LoadAllEquationList();

            result = null;

            view.KeyEvent += OnKeyPressed!;
            view.EqualEvent += OnEqualPressed!;
            view.ClearEvent += OnClearPressed!;
            view.DeleteEvent += OnDeletePressed!;

            view.CalculateFromAFileEvent += OnCalculateFromAFilePressed!;
            view.ExportToAFileEvent += OnExportToAFilePressed;
            view.DeleteSelectedRowsEvent += OnDeleteSelectedRowsPressed;

            view.OpenHistoryEvent += OnHistoryOpenPressed!;
        }

        private void LoadAllEquationList()
        {
            equationList = model.GetAll();
            equationBindingSource.DataSource = equationList;
        }

        private void OnKeyPressed(object sender, string key)
        {
            if (result != null)
            {
                view.Display = result.Substring(1);
                result = null;
            }
            view.Display += key;
        }

        private async void OnEqualPressed(object sender, EventArgs eventArgs)
        {
            if (result == null)
            {
                result = model.Calculate(view.Display);
                view.Display += result;

                await model.AddRow(view.Display);
            }
        }

        private void OnClearPressed(object sender, EventArgs eventArgs)
        {
            view.Display = model.Clear();
            result = null;
        }

        private void OnDeletePressed(object sender, EventArgs eventArgs)
        {
            view.Display = model.Delete(view.Display);

            if (!view.Display.Contains("="))
            {
                result = null;
            }
        }

        private async void OnCalculateFromAFilePressed(object sender, EventArgs eventArgs)
        {
            string fileName = model.SelectAFile();
            await model.CalculateFromAFile(fileName);
        }

        private async void OnExportToAFilePressed(object sender, EventArgs eventArgs)
        {
            LoadAllEquationList();
            string fileName = model.CreateAFile();
            await model.ExportToAFile(equationList, fileName);
        }

        private async void OnDeleteSelectedRowsPressed(object sender, EventArgs eventArgs)
        {
            List<EquationModel> equationList = new List<EquationModel>();

            await model.RemoveSelectedRows(view.SelectedRows);

            LoadAllEquationList();   
        }

        private void OnHistoryOpenPressed(object sender, EventArgs eventArgs)
        {
            LoadAllEquationList();
        }
    }
}
