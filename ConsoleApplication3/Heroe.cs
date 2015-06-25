using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public abstract class Heroe
    {
        public String nombre;
        public String genero;
        public String arma;
        public String tipo;
        public int ataque;
        public int Hp;
        public virtual void Atacar()
        {
            Console.WriteLine("{0} Ataco con su {1}!!",this.nombre,this.arma);
        }
        public virtual void Daño()
        {
            Console.WriteLine("El hereo recibio Daño");
        }
    }
}
