using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Arquero : Heroe
    {
        public int rango;
        public Arquero(String nombre, String genero)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.Hp = 100;
            this.ataque = 15;
            this.arma = "Arco";
            this.tipo = "Arquero";
            this.rango = 20;

        }
        public void EstadisticasArquero()
        {
            Console.WriteLine("Estadisticas del Heroe:\nNombre: {0}\nGenero: {1}\nHP: {2}\nTipo: {3}\nPoder de ataque: {4}\nArma: {5}\nRango: {6}", this.nombre, this.genero, this.Hp, this.tipo, this.ataque, this.arma, this.rango);
        }
    }
}
