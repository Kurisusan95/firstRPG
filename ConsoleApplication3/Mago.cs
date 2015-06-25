using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Mago : Heroe
    {
        public String encantamiento;
        public Mago(String nombre, String genero)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.Hp = 80;
            this.ataque = 20;
            this.arma = "Baculo";
            this.tipo = "Mago";
            this.encantamiento = "Rayo congelador";

        }
        public void EstadisticasMago()
        {
            Console.WriteLine("Estadisticas del Heroe:\nNombre: {0}\nGenero: {1}\nHP: {2}\nTipo: {3}\nPoder de ataque: {4}\nArma: {5}\nEncantamiento: {6}", this.nombre, this.genero, this.Hp, this.tipo, this.ataque, this.arma, this.encantamiento);
        }
    }
}
