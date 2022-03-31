using System;
using CompositeEx.Leaf;

namespace CompositeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Organizacao organizacao = new Organizacao { Nome = "JcmSoft Inc." }; // INSTÂNCIA DA ORGANIZAÇÃO DEFININDO NOME
            //
            Organizacao departamentoTI = new Organizacao { Nome = " TI " }; //CRIADO DEPARTAMENTO E FUNCIONÁRIOS
            departamentoTI.Add(new Funcionario { Id = 1001, Nome = "Maria", Horas = 8 });
            departamentoTI.Add(new Funcionario { Id = 1002, Nome = "Miguel", Horas = 6 });
            departamentoTI.Add(new Funcionario { Id = 1005, Nome = "Samuel", Horas = 8 });
            //
            Organizacao departamentoContabilidade = new Organizacao { Nome = " Contabilidade " }; // OUTRO DEPARTAMENTO E FUNCIONÁRIOS
            departamentoContabilidade.Add(new Funcionario { Id = 1003, Nome = "Beatriz", Horas = 7 });
            departamentoContabilidade.Add(new Funcionario { Id = 1004, Nome = "Paulo", Horas = 5 });
            //
            organizacao.Add(departamentoTI);  // INCLUINDO DEPARTAMENTOS NA ORGANIZAÇÃO, 
            organizacao.Add(departamentoContabilidade); // PARA MONTAR ESTRUTURA DE ÁRVORE
            organizacao.GetHoraTrabalhada(); // CHAMANDO MÉTODO GETHORATRABALHADA 
            //
            Console.ReadKey();
        }
    }
}
