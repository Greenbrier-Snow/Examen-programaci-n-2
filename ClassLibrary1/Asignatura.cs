using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudiantes;

namespace asignaturas
{
    public class Asignatura
    {
        string nombre;
        string profesor;
        Estudiante[] estudiantes;
        int cantidadEstudiantes;

        public Asignatura(string nombre, string profesor) { 
            this.nombre = nombre; 
            this.profesor = profesor;
            estudiantes = new Estudiante[10];
            cantidadEstudiantes = 0;
        }

        public void AgregarEstudiante(Estudiante estudiante) {
            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i] == null)
                {
                    cantidadEstudiantes++;
                    estudiantes[i] = estudiante; break;
                }
                else if (i == 9) {
                    Console.WriteLine("La materia ya llego a su limite de alumnos: 10");
                }
            }
           
        }

        public void EliminarEstudiante(Estudiante estudiante) { 
            for(int i = 0;i < estudiantes.Length;i++){
                if (estudiante == estudiantes[i])
                {
                    cantidadEstudiantes--;
                    Console.WriteLine("El alumno fue eliminado");
                    estudiantes[i] = null; break;
                }else if(i == 9){
                    Console.WriteLine("El estudiante seleccionado no se encuentra en la asignatura");
                }
            }
            
        }


    }
}
