using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales.Animales
{
    public abstract class Animal
    {
        private int edad;
        private double altura;
        private double peso;
        public Animal(int edad, double altura, double peso)
        {
            this.edad = edad;
            this.altura = altura;
            this.peso = peso;
        }
        public int Edad {
            get
            {
                return edad;
            }
        }
        public double Altura {
            get
            {
                return altura;
            }
        }
        public double Peso {
            get
            {
                return peso;
            }
        }

        public virtual string Imprimir()
        {
            return "Edad: " + edad + ", Altura: "  + altura+ ", Peso: " + peso;
        }

        public abstract string ImprimirComida();

    }
}
