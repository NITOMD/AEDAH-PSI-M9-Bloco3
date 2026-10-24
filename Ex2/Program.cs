using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func1 = new Funcionario();

            Func1.Nome = "Pedro";
            Func1.CodigoIdentificacao = 1;
            Func1.SalarioBase = 1500;
            Func1.DataAdmissao = new DateTime(2026, 5, 12);
            Func1.PossuiSubsidioAlimentacao = true;

            Func1.ExibirPerfil();
            Console.ReadKey();

        }
    }
}
