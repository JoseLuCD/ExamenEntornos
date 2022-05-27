using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Entornos
{    
    class Asignatura
    {
        public string CodigoAsignatura;
        public string NombreAsignatura;
        public double NotaPrimerTrimestre;
        public double NotaSegungoTrimestre;
        public double NotaTercerTrimestre;
        public double NotaFinal;
        //Aqui hemos cambiado el nombre y la guia de estilos de estos para que sean mas legibles y hemos cambiado su posicion arriba ya que por estilo las variables suelen ir el la parte de arriba

        public Asignatura(string CodigoAsignatura, string NombreAsignatura, double NotaPrimerTrimestre, double NotaSegungoTrimestre, double NotaTercerTrimestre, double NotaFinal)
        {
            this.CodigoAsignatura = CodigoAsignatura;
            this.NombreAsignatura = NombreAsignatura;
            this.NotaPrimerTrimestre = NotaPrimerTrimestre;
            this.NotaSegungoTrimestre = NotaSegungoTrimestre;
            this.NotaTercerTrimestre = NotaTercerTrimestre;
            this.NotaFinal = NotaFinal;
            //En este codigo, lo que hemos hecho ha sido la tabulacion para quitar espacios en blanco
        }


        public void IntroducirMateria(string codAsignatura, string nombreAsignatura)
        {
            this.CodigoAsignatura = codAsignatura; this.NombreAsignatura = nombreAsignatura;
            //En este codigo hemos hecho cambios en las variables para que sean mas legibles y hemos quitado espacios en blanco.
        }

        /// <summary>
        /// En esta funcion hemos hecho varias refactorizaciones como la buena tabulacion del codigo, quitar llaves innecesarias y reordenar los campos para que el codigo tenga sentido.
        /// Tambien hemos hecho unos cambios en el codigo para que las variables no se queden sin hacer nada.
        /// </summary>
        /// <param name="notaExamen1"></param>
        /// <param name="notaExamen2"></param>
        /// <param name="notaExamen3"></param>
        /// <param name="notaPracticas1"></param>
        /// <param name="notaPracticas2"></param>
        /// <param name="notaPracticas3"></param>
        /// <returns>Esta funcion imoprimira en pantalla la nota de las practicas y examenes</returns>
        public void IntroducirlasNotas(double notaExamen1, double notaExamen2, double notaExamen3, double notaPracticas1, double notaPracticas2, double notaPracticas3)
        {
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                var Trimestre = Console.ReadLine();

                switch (Trimestre)
                {
                    case "1":
                        notaPracticas1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota de las prácticas: ", notaPracticas1);
                        notaExamen1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ", notaExamen1);
                        break;

                    case "2":
                        notaPracticas2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota de las prácticas: ", notaPracticas2);
                        notaExamen2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ", notaExamen2);
                        break;

                    case "3":
                        notaPracticas3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota de las prácticas: ", notaPracticas3);
                        notaExamen3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ", notaExamen3);
                        break;
                }
            }
        }

        /// <summary>
        /// Para estas cuatro funciones hemos encapsulado el valor final de la nota en una variable para que sea todo mas entendible. Ademas hemos cambiado sus nombres para hacerlo mas legible
        /// </summary>
        /// <var name="nota">Esta variable dice la nota de cada trimestre</var>
        /// <returns>devuelve la nota del primer trimestre</returns>
        public double calculodelaNota1(double notaExamen1, double notaPracticas1)
        {
            var nota = (notaExamen1 * 0.8) + (notaPracticas1 * 0.2);
            this.NotaPrimerTrimestre = nota;
            return this.NotaPrimerTrimestre;
        }

        /// <summary>
        /// </summary>
        /// <param name="notaExamen2"></param>
        /// <param name="notaPracticas2"></param>
        /// <returns>devuelve la nota del segundo trimestre</returns>
        public double calculodelaNota2(double notaExamen2, double notaPracticas2)
        {
            var nota = (notaExamen2 * 0.8) + (notaPracticas2 * 0.2);
            this.NotaSegungoTrimestre = nota;
            return this.NotaSegungoTrimestre;
        }

        /// <summary>
        /// </summary>
        /// <param name="notaExamen3"></param>
        /// <param name="notaPracticas3"></param>
        /// <returns>devuelve la nota del tercer trimestre</returns>
        public double calculodelaNota3(double notaExamen3, double notaPracticas3)
        {
            var nota = (notaExamen3 * 0.8) + (notaPracticas3 * 0.2);
            this.NotaTercerTrimestre = nota;
            return this.NotaTercerTrimestre;
        }

        /// <summary>
        /// </summary>
        /// <returns>Devuelvela nota media</returns>
        public double Calculodelamedia()
        {
            var media = (this.NotaPrimerTrimestre + this.NotaSegungoTrimestre + this.NotaTercerTrimestre) / 3;
            this.NotaFinal = media;
            return this.NotaFinal;
        }
    }
}
