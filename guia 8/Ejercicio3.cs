using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_8
{
    class Ejercicio3
    {
        #region
        public struct Materia
        {
            public string nombre;
            private double nota;

            public void setNota(double nota)
            {
                this.nota = nota;
            }
            public double getNota()
            {
                return this.nota;
            }
            public string resultado()
            {
                return "aprovado";
            }
        }
        public struct Alumno
        {
            public string carnet;
            public string nombre;
            public string carrera;
            public Materia materia1;
            public Materia materia2;
            public Materia materia3;
            public Materia materia4;
        }
        #endregion
        public void ejer3()
        {
            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            int cAlumnos = 0;
            Console.WriteLine("Cuantos alumnos seran?");
            cAlumnos = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumnos = new Alumno[cAlumnos];
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Nombre alumno " + (i + 1));
                alumnos[i].nombre = Console.ReadLine();
                Console.WriteLine("Nombre Carnet " + (i + 1));
                alumnos[i].carnet = Console.ReadLine();
                Console.WriteLine("Carrera alumno " + (i + 1));
                alumnos[i].carrera = Console.ReadLine();
                do
                {
                    Console.WriteLine("nota materia 1 del alumno " + (i + 1));
                    nota1 = Convert.ToDouble(Console.ReadLine());
                } while (nota1 < 0 || nota1 > 10);
                alumnos[i].materia1.setNota(nota1);
                do
                {
                    Console.WriteLine("nota materia 2 del alumno " + (i + 1));
                    nota2 = Convert.ToDouble(Console.ReadLine());
                } while (nota2 < 0 || nota2 > 10);
                alumnos[i].materia2.setNota(nota2);
                do
                {
                    Console.WriteLine("nota materia 3 del alumno " + (i + 1));
                    nota3 = Convert.ToDouble(Console.ReadLine());
                } while (nota3 < 0 || nota3 > 10);
                alumnos[i].materia3.setNota(nota3);
                do
                {
                    Console.WriteLine("nota materia 4 del alumno " + (i + 1));
                    nota4 = Convert.ToDouble(Console.ReadLine());
                } while (nota4 < 0 || nota4 > 10);
                alumnos[i].materia4.setNota(nota4);
            }
            foreach (var alumno in alumnos)
            {
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine("Nombre: " + alumno.nombre);
                Console.WriteLine("Carnet: " + alumno.carnet);
                Console.WriteLine("carrera: " + alumno.carrera);
                //materia1
                if (alumno.materia1.getNota() > 6)
                {
                    Console.WriteLine("Materia 1: " + alumno.materia1.getNota() + " " + alumno.materia1.resultado());
                }
                else
                {
                    Console.WriteLine("Materia 1: " + alumno.materia1.getNota() + " Reprobada");
                }
                //materia2
                if (alumno.materia2.getNota() > 6)
                {
                    Console.WriteLine("Materia 2: " + alumno.materia2.getNota() + " " + alumno.materia2.resultado());
                }
                else
                {
                    Console.WriteLine("Materia 2: " + alumno.materia2.getNota() + " Reprobada");
                }
                //materia3
                if (alumno.materia3.getNota() > 6)
                {
                    Console.WriteLine("Materia 3: " + alumno.materia3.getNota() + " " + alumno.materia3.resultado());
                }
                else
                {
                    Console.WriteLine("Materia 3: " + alumno.materia3.getNota() + " Reprobada");
                }
                //materia4
                if (alumno.materia4.getNota() > 6)
                {
                    Console.WriteLine("Materia 4: " + alumno.materia4.getNota() + " " + alumno.materia4.resultado());
                }
                else
                {
                    Console.WriteLine("Materia 4: " + alumno.materia4.getNota() + " Reprobada");
                }
                Console.WriteLine("\nPresione <ENTER> para continuar");
                Console.ReadKey();
            }
        }
    }
}
