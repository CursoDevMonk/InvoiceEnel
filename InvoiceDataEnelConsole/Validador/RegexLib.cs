using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DadosFaturaEnelConsole.Validador
{
    class RegexLib
    {
        public bool IsMatchNumeros(string resp)
        {
            string er = @"^\d+$";
            return Regex.IsMatch(resp, er);
        }

        public bool IsMatchLetras(string resp)
        {
            string er = @"^[ a-zA-Z á]*$";
            return Regex.IsMatch(resp, er);
        }

        public bool IsMatchCep(string resp)
        {
            string er = @"^\d{5}-\d{3}$";
            return Regex.IsMatch(resp, er);
        }

        public bool IsMatchNumerosELetras(string resp)
        {
            string er = @"^[A-Za-z0-9]\d+[A-Za-z0-9]$";
            return Regex.IsMatch(resp, er);
        }

    }
}
