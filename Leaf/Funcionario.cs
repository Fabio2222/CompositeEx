using CompositeEx.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEx.Leaf
{

    //Representa o Leaf
    public class Funcionario : HoraTrabalhada
    {

        public int Id { get; set; }  // DEFINIU ID
        public int Horas { get; set; }  // DEFINIU HORAS QUE FUNCIONÁRIO VAI REGISTRAR
        public override int GetHoraTrabalhada()  // SUBSTITUIU O MÉTODO GETHORATRABALHADA
        {
            Console.WriteLine($"O Funcionário {Id}-{Nome} registrou {Horas} trabalhadas");
            return Horas; // RETORNA HORAS DO FUNCIONÁRIO QUE FORAM REGISTRADAS
        }
    }
}
