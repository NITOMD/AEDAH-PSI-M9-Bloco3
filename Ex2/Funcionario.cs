using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Funcionario
    {
        public string Nome;
        public int CodigoIdentificacao;
        public double SalarioBase;
        public DateTime DataAdmissao;
        public bool PossuiSubsidioAlimentacao;

        public void ExibirPerfil() 
        {
            Console.WriteLine("********Dados Funcionários**********");
            Console.WriteLine(Nome);
            Console.WriteLine(CodigoIdentificacao);
            Console.WriteLine(SalarioBase);
            Console.WriteLine(DataAdmissao);
            Console.WriteLine(PossuiSubsidioAlimentacao);
            Console.WriteLine("************************************");
        }
    }
}
