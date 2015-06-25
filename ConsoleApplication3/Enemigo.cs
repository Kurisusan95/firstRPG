using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Enemigo
    {
        public String nombre;
        public String genero;
        public String arma;
        public int ataque;
        public int Hp;

        public Enemigo()
        {
            this.nombre = "Orco";
            this.genero = "Masculino";
            this.Hp = 10;
            this.ataque = 25;
            this.arma = "Hacha";
        }
    }
}