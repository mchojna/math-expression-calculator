using Calculator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Model
{
    internal class CalculatorModel : ICalculatorModel
    {
        private OpenFileDialog? openFileDialog;
        private SaveFileDialog? saveFileDialog;
        public CalculatorModel()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.Filter = "Text Files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 2;

            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Create File";
            saveFileDialog.Filter = "Text Files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 2;
        }

        public string Calculate(string equation)
        {
            string result;

            if (!equation.Contains("/0") && !equation.Contains("ERROR"))
            {
                if (equation.StartsWith("-"))
                {
                    equation = "0" + equation;
                }

                string pattern = @"([*()\^\/\+\-%])";
                string[] equationSubstring = Regex.Split(equation, pattern);

                List<string> equationList = new List<string>();

                foreach (string substring in equationSubstring)
                {
                    if (!substring.Equals(" ") && !substring.Equals(""))
                    {
                        equationList.Add(substring.ToString());
                    }
                }
                result = CalculateWholeEquation(equationList);
            }
            else
            {
                result = "=ERROR";
            }
            return result;
        }

        private string CalculateWholeEquation(List<string> equationList)
        {
            equationList = CalculateBrackets(equationList);
            equationList = CalculateEquation(equationList);

            return $"={string.Join("", equationList.ToArray())}";
        }

        private List<string> CalculateBrackets(List<string> equationList)
        {
            int index = 0;

            int indexOfStartBracket = -1;
            int indexOfEndBracket = -1;

            while (equationList.Contains("(") && equationList.Contains(")"))
            {
                if (equationList[index].Equals("("))
                {
                    indexOfStartBracket = index;
                }
                if (equationList[index].Equals(")"))
                {
                    indexOfEndBracket = index;
                }

                if (indexOfStartBracket != -1 && indexOfEndBracket != -1)
                {
                    equationList = CalculateBracketsEquation(equationList, indexOfStartBracket, indexOfEndBracket);

                    index = -1;
                    indexOfStartBracket = -1;
                    indexOfEndBracket = -1;
                }

                if ((index + 1) < equationList.Count)
                {
                    index += 1;
                }
                else
                {
                    index = 0;
                    indexOfStartBracket = -1;
                    indexOfEndBracket = -1;
                }
            }
            return equationList;
        }

        private List<string> CalculateEquation(List<string> equationList)
        {
            int index = 0;

            while (equationList.Contains("*") || equationList.Contains("/") || equationList.Contains("%"))
            {
                if (equationList[index] == "*" || equationList[index] == "/" || equationList[index] == "%")
                {
                    equationList = CalculateSingleEquation(equationList, index);

                    index = -1;
                }
                index++;
            }

            while (equationList.Contains("+") || equationList.Contains("-"))
            {
                if (equationList[index] == "+" || equationList[index] == "-")
                {
                    equationList = CalculateSingleEquation(equationList, index);

                    index = -1;
                }
                index++;
            }
            return equationList;
        }

        private List<string> CalculateBracketsEquation(List<string> equationList, int indexOfStartBracket, int indexOfEndBracket)
        {
            List<string> leftEquationList = equationList.GetRange(0, indexOfStartBracket);
            List<string> midEquationList = equationList.GetRange((indexOfStartBracket + 1), (indexOfEndBracket - indexOfStartBracket - 1));
            List<string> rightEquationList = equationList.GetRange((indexOfEndBracket + 1), (equationList.Count - indexOfEndBracket - 1));

            List<string> outcomeList = CalculateEquation(midEquationList);

            equationList.Clear();
            equationList.InsertRange(0, leftEquationList);
            equationList.InsertRange(equationList.Count, outcomeList);
            equationList.InsertRange(equationList.Count, rightEquationList);

            return equationList;
        }

        private List<string> CalculateSingleEquation(List<string> equationList, int index)
        {
            List<string> leftEquationList = new List<string>();
            List<string> rightEquationList = new List<string>();

            string equation = DoMathOperation(equationList[index - 1], equationList[index], equationList[index + 1]);

            if (index - 2 > 0)
            {
                leftEquationList = equationList.GetRange(0, index - 1);
            }
            if (index + 2 < equationList.Count)
            {
                rightEquationList = equationList.GetRange(index + 2, (equationList.Count - (index + 2)));
            }

            equationList.Clear();
            equationList.InsertRange(0, leftEquationList);
            equationList.Insert(equationList.Count, equation);
            equationList.InsertRange(equationList.Count, rightEquationList);

            return equationList;
        }

        private string DoMathOperation(string argumentA, string operation, string argumentB)
        {
            return operation switch
            {
                "*" =>
                    ((double.Parse(argumentA)) * (double.Parse(argumentB))).ToString(CultureInfo.InvariantCulture),
                "/" =>
                    ((double.Parse(argumentA)) / (double.Parse(argumentB))).ToString(CultureInfo.InvariantCulture),
                "%" =>
                    ((double.Parse(argumentA)) % (double.Parse(argumentB))).ToString(CultureInfo.InvariantCulture),
                "+" =>
                    ((double.Parse(argumentA)) + (double.Parse(argumentB))).ToString(CultureInfo.InvariantCulture),
                "-" =>
                    ((double.Parse(argumentA)) - (double.Parse(argumentB))).ToString(CultureInfo.InvariantCulture),
                _ => ""
            };
        }

        public string Clear()
        {
            return "";
        }

        public string Delete(string value)
        {
            if (value.Length > 0)
            {
                return value.Substring(0, value.Length - 1);
            }
            else
            {
                return value;
            }
        }

        public string SelectAFile()
        {
            openFileDialog.FileName = null;
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }

        public async Task CalculateFromAFile(string fileName)
        {
            string inputFilePath = fileName;

            try
            {
                if (fileName.Length != 0)
                {

                    List<string> inputList = new List<string>();
                    using (StreamReader reader = new StreamReader(inputFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = await reader.ReadLineAsync();
                            if (line != null)
                            {
                                inputList.Add(line);
                            }
                        }
                    }

                    List<string> outputList = new List<string>();
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        outputList.Add($"{inputList[i]}{Calculate(inputList[i])}");
                    }

                    string outputFilePath = inputFilePath.Replace("input.csv", "output.csv");
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        foreach (string output in outputList)
                        {
                            await writer.WriteLineAsync(output);
                            await AddRow(output);
                        }
                    };
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string CreateAFile()
        {
            saveFileDialog.FileName = null;
            saveFileDialog.ShowDialog();
            return saveFileDialog.FileName;
        }

        public async Task ExportToAFile(IEnumerable<EquationModel> equationList, string fileName)
        {
            string inputFilePath = fileName;

            try
            {
                if (fileName.Length != 0)
                {
                    using (StreamWriter writer = new StreamWriter(inputFilePath))
                    {
                        foreach (EquationModel equationModel in equationList)
                        {
                            string outputString = equationModel.Id + equationModel.Equation;
                            await writer.WriteLineAsync(outputString);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public async Task AddRow(string value)
        {
            try
            {
                using (EquationContext context = new EquationContext())
                {
                    EquationModel equation = new EquationModel()
                    {
                        Equation = value
                    };
                    await context.AddAsync(equation);
                    await context.SaveChangesAsync();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public async Task RemoveSelectedRows(DataGridViewSelectedRowCollection SelectedRows)
        {
            try
            {
                List<EquationModel> equationList = new List<EquationModel>();

                foreach (DataGridViewRow item in SelectedRows)
                {
                    equationList.Add(new EquationModel()
                    {
                        Id = int.Parse(item.Cells[0].Value.ToString()),
                        Equation = item.Cells[1].Value.ToString(),
                    });
                }

                using (EquationContext context = new EquationContext())
                {
                    foreach (EquationModel equationModel in equationList)
                    {
                        context.Equations.Remove(equationModel);
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public IEnumerable<EquationModel> GetAll()
        {
            List<EquationModel> equationList = new List<EquationModel>();

            using (EquationContext context = new EquationContext())
            {
                equationList = context.Equations.ToList();
            }
            return equationList;
        }
    }
}
