using Calculator.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    internal interface ICalculatorModel
    {
        string Calculate(string equation);
        string Clear();
        string Delete(string value);

        string SelectAFile();
        Task CalculateFromAFile(string fileName);

        Task ExportToAFile(IEnumerable<EquationModel> equationList, string fileName);

        Task AddRow(string value);
        Task RemoveSelectedRows(DataGridViewSelectedRowCollection SelectedRows);
        IEnumerable<EquationModel> GetAll();
    }
}
