using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Entornos
{
    class Program
    {
        /// <summary>
        /// Esta clase la hemos extraido del codigo anterior para meterla en su propia clase ya que es un main.
        /// En este main simplemente se crea una asignatura y se le asignan parametros.
        /// </summary>
        static void main()
        {
            Asignatura asigejemplo = new Asignatura("0521385", "Entornos  de Desarrollo",5,5,5,5);
        }
    }
}
