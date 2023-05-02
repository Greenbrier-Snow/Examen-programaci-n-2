using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudiantes;
using asignaturas;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante Gio = new Estudiante("Giovanni Nievs", 22);
            Estudiante Nala = new Estudiante("Nalani Hernandez",20);
            Estudiante Josue = new Estudiante("Josue Magaña", 20);
            Estudiante Nico = new Estudiante("Nicolas Peñate", 20);
            Estudiante Natha = new Estudiante("Nathanael Cano", 20);
            Estudiante Alvaro = new Estudiante("Diego Farias", 20);
            Estudiante Liz = new Estudiante("Liz Espinoza", 20);
            Estudiante Alex = new Estudiante("Alejandro Cabrera", 20);
            Estudiante Chochue = new Estudiante("Josue Suastegui", 20);
            Estudiante Leo = new Estudiante("Leonardo Garcia", 20);
            Estudiante Gabo = new Estudiante("Gabriel Aguilar", 20);

            Asignatura Progra = new Asignatura("Programacion 2", "Fernando Acuña");
            Asignatura Redes = new Asignatura(" Redes de computadoras", "Fernando Acuña");
            Asignatura Conta = new Asignatura("Conta y Costos", "Fernando Acuña");
            Asignatura IntroTics = new Asignatura(" Introduccion a las Tics's", "Fernando Acuña");
            Asignatura Circuitos = new Asignatura("Circuitos Electricos", "Fernando Acuña");
            Asignatura MatesDisc = new Asignatura("Metematicas Discretas 2", "Fernando Acuña");

            Nala.AgregarAsignatura(Progra);
            Nala.AgregarAsignatura(Redes);
            Nala.AgregarAsignatura(Conta);
            Nala.AgregarAsignatura(IntroTics);
            Nala.AgregarAsignatura(Circuitos);
            Nala.AgregarAsignatura(MatesDisc);

            Progra.AgregarEstudiante(Nala);
            Progra.AgregarEstudiante(Josue);
            Progra.AgregarEstudiante(Nico);
            Progra.AgregarEstudiante(Natha);
            Progra.AgregarEstudiante(Alvaro);
            Progra.AgregarEstudiante(Liz);
            Progra.AgregarEstudiante(Alex);
            Progra.AgregarEstudiante(Chochue);
            Progra.AgregarEstudiante(Leo);
            Progra.AgregarEstudiante(Gabo);
            Progra.AgregarEstudiante(Gio);


            Nala.EliminarAsignatura(Redes);

            Progra.EliminarEstudiante(Chochue);


        }
    }
}
