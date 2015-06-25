using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Guerrero : Heroe
    {
        public int armadura;
        public Guerrero(String nombre, String genero)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.Hp = 100;
            this.ataque = 10;
            this.arma = "Espada";
            this.tipo = "Guerrero";
            this.armadura = 20;


        }
        public void EstadisticasGuerrero()
        {
            Console.WriteLine("Estadisticas del Heroe:\nNombre: {0}\nGenero: {1}\nHP: {2}\nTipo: {3}\nPoder de ataque: {4}\nArma: {5}\nArmadura: {6}", this.nombre, this.genero, this.Hp, this.tipo, this.ataque, this.arma, this.armadura);
        }
    }
}
