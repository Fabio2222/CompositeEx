using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEx.Component
{
    //CLASSE ABSTRATA HORA TRABALHADA
    //representa o Component
    public abstract class HoraTrabalhada
    {
        public HoraTrabalhada()
        { }
        public string Nome { get; set; }
        public abstract int GetHoraTrabalhada();  //FUNCIONALIDADE COMUM. VAI CALCULAR HORA TRABALHADA.
        public virtual void Add(HoraTrabalhada component)  //MÉTODO ADD. USADO PARA INCLUIR DEPARTAMENTOS 
        {                                                   // E FUNCIONÁRIOS NOS DEPARTAMENTOS
            throw new NotImplementedException();
        }
        public virtual void Remove(HoraTrabalhada component)  //MÉTODO REMOVE APENAS PARA ILUSTRAR.
        {
            throw new NotImplementedException();
        }
    }
}
