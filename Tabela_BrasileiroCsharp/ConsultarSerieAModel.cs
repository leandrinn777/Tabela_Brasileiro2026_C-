using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_BrasileiroCsharp
{
    public class ConsultarSerieAModel
    {
        public int IdSerieA { get; set; }
        public string? NomeClube { get; set; }
        public int PontosClube { get; set; }
        public int JogosClube { get; set; }
        public decimal SaldoGols { get; set; }
        public int VitoriasClube { get; set; }
        public int DerrotasClube { get; set; }
        public int PosicaoTabela { get; set; }
    }
}
