using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeEx.Component;

namespace CompositeEx.Leaf
{
    //CLASSE ORGANIZAÇÃO
    //Representa o Composite. É UMA CLASSE CONCRETA.
    public class Organizacao : HoraTrabalhada  // HERDA DA CLASSE ABSTRATA HORA TRABALHADA
    {
        protected List<HoraTrabalhada> departamentos = new List<HoraTrabalhada>(); //CRIANDO UMA LISTA HORA TRABALHADA
                                                                                   // CALCULAR HORA TRABALHADA. AQUI ESTÁ ESTRUTURA DE ÁRVORES.
        public override void Add(HoraTrabalhada component)
        {
            departamentos.Add(component);
        }

        public override void Remove(HoraTrabalhada component)
        {
            departamentos.Remove(component);
        }
        //funcionalidade comum

        public override int GetHoraTrabalhada() //USAR MÉTODO PARA CALCULAR HORA DOS FUNCIONÁRIOS,
        {                                           // DOS DEPARTAMENTOS, DA ORGANIZAÇÃO.
            var horasTrabalhadasDepartamento = 0;
            foreach (var departamento in departamentos) // EXIBE HORAS FUNCIONÁRIOS
            {
                horasTrabalhadasDepartamento += departamento.GetHoraTrabalhada(); // SOMA DAS HORAS TOTAIS
            }
            Console.WriteLine($"{Nome} registrou um total de [{horasTrabalhadasDepartamento}] horas\n");
            return horasTrabalhadasDepartamento;
        }
    }
}
