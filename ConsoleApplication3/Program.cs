using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            String repetir="si";
            do
            {
                Console.WriteLine("El reino necesita nuevos heroes!");
                Console.WriteLine("Desea contratar un Mago, un Guerrero o un Arquero?");
                String tipo = Console.ReadLine();

                if (tipo == "Guerrero")
                {
                    Console.WriteLine("Cual es el nombre del Guerrero?");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Cual es el genero del Guerrero?");
                    String genero = Console.ReadLine();
                    Guerrero milanor = new Guerrero(nombre, genero);
                    milanor.EstadisticasGuerrero();
                    Enemigo orco = new Enemigo();
                    do
                    {
                        Console.WriteLine("Un enemigo se interpone entre {0} y su reino, Desea que el heroe ataque?(si/no)", nombre);
                        String atacar = Console.ReadLine();
                        if (atacar == "si")
                        {
                            milanor.Atacar();
                            orco.Hp -= milanor.ataque;
                            milanor.Hp -= orco.ataque;
                            Console.WriteLine("El heroe recibio {0} de daño y su enemigo {1} de daño", orco.ataque, milanor.ataque);
                            Console.WriteLine("Vida restante del heroe: {0}\nVida restante del orco: {1}", milanor.Hp, orco.Hp);
                        }
                        else
                        {
                            Console.WriteLine("El heroe recibe {0} de daño por su temor", orco.ataque+10);
                            milanor.Hp -= orco.ataque;
                        }
                    } while (orco.Hp > 0 && milanor.Hp > 0);
                    if (orco.Hp <= 0)
                    {
                        Console.WriteLine("El {0} ha sido derrotado", orco.nombre);
                    }
                    else
                    {
                        Console.WriteLine("{0} ha sido derrotado", milanor.nombre);
                    }
                }
                if (tipo == "Mago")
                {
                    Console.WriteLine("Cual es el nombre del Mago?");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Cual es el genero del Mago?");
                    String genero = Console.ReadLine();
                    Mago isis = new Mago(nombre, genero);
                    isis.EstadisticasMago();
                    Enemigo orco = new Enemigo();
                    do
                    {
                    Console.WriteLine("Un enemigo se interpone entre {0} y su reino, Desea que el heroe ataque?(si/no)", nombre);
                    String atacar = Console.ReadLine();
                    if (atacar == "si")
                    {
                        isis.Atacar();
                        orco.Hp -= isis.ataque;
                        isis.Hp -= orco.ataque;
                        Console.WriteLine("El heroe recibio {0} de daño y su enemigo {1} de daño", orco.ataque, isis.ataque);
                        Console.WriteLine("Vida restante del heroe: {0}\nVida restante del orco: {1}", isis.Hp, orco.Hp);

                    }
                    else
                    {
                        Console.WriteLine("El heroe recibe {0} de daño por su temor", orco.ataque+10);
                        isis.Hp -= orco.ataque;
                    }
                    } while (orco.Hp > 0 && isis.Hp > 0);
                    if (orco.Hp <= 0)
                    {
                        Console.WriteLine("El {0} ha sido derrotado", orco.nombre);
                    }
                    else
                    {
                        Console.WriteLine("{0} ha sido derrotado", isis.nombre);
                    } 
                }
                if (tipo == "Arquero")
                {
                    Console.WriteLine("Cual es el nombre del Arquero?");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Cual es el genero del Arquero?");
                    String genero = Console.ReadLine();
                    Arquero robinHood = new Arquero(nombre, genero);
                    robinHood.EstadisticasArquero();
                    Enemigo orco = new Enemigo();
                    do
                    {
                        Console.WriteLine("Un enemigo se interpone entre {0} y su reino, Desea que el heroe ataque?(si/no)", nombre);
                        String atacar = Console.ReadLine();
                        if (atacar == "si")
                        {
                            robinHood.Atacar();
                            robinHood.Hp -= orco.ataque;
                            orco.Hp -= robinHood.ataque;
                            Console.WriteLine("El heroe recibio {0} de daño y su enemigo {1} de daño", orco.ataque, robinHood.ataque);
                            Console.WriteLine("Vida restante del heroe: {0}\nVida restante del orco: {1}", robinHood.Hp, orco.Hp);
                        }
                        else
                        {
                            Console.WriteLine("El heroe recibe {0} de daño por su temor",orco.ataque+10);
                            robinHood.Hp -=orco.ataque;
                        }
                    }while(orco.Hp >0 && robinHood.Hp>0 );
                    if(orco.Hp<=0)
                    {
                    Console.WriteLine("El {0} ha sido derrotado",orco.nombre);
                    }
                    else
                    {
                        Console.WriteLine("{0} ha sido derrotado", robinHood.nombre);
                    } 

                }
                if (tipo != "Arquero" && tipo != "Guerrero" && tipo != "Mago")
                {
                    Console.WriteLine("El Heroe que solicita no esta disponible");
                }
                Console.WriteLine("Desea jugar de nuevo?(si/no)");
                repetir = Console.ReadLine();
            } while (repetir == "si");

        }
    }
}
