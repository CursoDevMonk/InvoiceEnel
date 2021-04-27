using System;
using System.Collections.Generic;
using System.Text;

namespace DadosFaturaEnelConsole.Model
{
    public class DadosFatura
    {
        public int Posicao { get; set; }
        public string Cliente { get; set; }
        public string Cep { get; set; }
        public string NmCasa { get; set; }
        public string Complemento { get; set; }
        public string Regiao { get; set; }
        public int Dia { get; set; }
        public string Mes { get; set; }
        public int Ano { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int Segundo { get; set; }
        public string Medidor { get; set; }
        public int Aparelho { get; set; }
        public int Kw { get; set; }
        public decimal Custo { get; set; }

    }
}
