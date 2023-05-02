using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asignaturas;

namespace estudiantes
{
    public class Estudiante
    {
        string nombre;
        int edad;
        Asignatura[] asignaturas;
        int cantidadAsignaturas;

        public Estudiante(string nombre, int edad) { 
            this.nombre = nombre; 
            this.edad = edad;
            asignaturas = new Asignatura[5];
            cantidadAsignaturas = 0;
        }

        public void AgregarAsignatura(Asignatura asignatura) { 
            for (int i = 0; i < asignaturas.Length; i++)
            {
                if (asignaturas[i] == null)
                {
                    cantidadAsignaturas++;
                    asignaturas[i] = asignatura; break;
                }
                else if(i == 4){
                    Console.WriteLine("La cantidad de asignaturas ya llego a su limite para este alumno: 5");
                }
            }
            

        }

        public void EliminarAsignatura(Asignatura asignatura) {
            for (int i = 0; i < asignaturas.Length; i++)
            {
                if (asignatura == asignaturas[i])
                {
                    cantidadAsignaturas--;
                    Console.WriteLine("La materia fue eliminada");
                    asignaturas[i] = null; break;
                }else if(i == 4){
                    Console.WriteLine("La asignatura seleccionada no se encuentra en la carga de asignaturas");
                }
            }
            
        }


    }
}
