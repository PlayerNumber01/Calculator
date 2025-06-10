using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public string Calculate(string expression)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(expression))
                {
                    return "0";
                }

                expression = expression.Replace("×", "*").Replace("÷", "/");

                if (Regex.IsMatch(expression, @"[^0-9+\-*/().]"))
                {
                    return "Error";
                }

                if (!AreParenthesesBalanced(expression))
                {
                    return "Error";
                }

                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                var result = row["expression"];

                if (result is DBNull)
                {
                    return "Error";
                }

                return FormatResult(result.ToString());
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        private bool AreParenthesesBalanced(string expression)
        {
            int count = 0;
            foreach (char c in expression)
            {
                if (c == '(')
                {
                    count++;
                }
                else if (c == ')')
                {
                    count--;
                    if (count < 0)
                    {
                        return false;
                    }
                }
            }
            return count == 0;
        }

        private string FormatResult(string result)
        {
            if (result.Contains("."))
            {
                result = result.TrimEnd('0').TrimEnd('.');
            }

            return string.IsNullOrEmpty(result) ? "0" : result;
        }
    }
}
