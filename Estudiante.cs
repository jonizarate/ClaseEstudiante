using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEstudiante
{
    internal class Estudiante
    {
        public string nombre { set; get; }
        public int numeroDeCuenta { set; get; }
        public short edad { set; get; }
        public int dni { set; get; }
        public string lugarDeNacimiento { set; get; }
        public string lugarDeProcedencia { set; get; } //nacionalidad
        public string carreraEstudiantil { set; get; }
        public bool asistioAClases { set; get; }

        public Estudiante()
        {
            nombre = "";
            numeroDeCuenta = 0;
            edad = 0;
            dni = 0;
            lugarDeNacimiento = "";
            lugarDeProcedencia = "";
            carreraEstudiantil = "";
            asistioAClases = true;
        }
        public Estudiante(string nombre, int numeroDeCuenta, short edad, int dni, string lugarDeNacimiento, string lugarDeProcedencia, string carreraEstudiantil,bool asistioAClases)
        {
            this.nombre = nombre;
            this.numeroDeCuenta = numeroDeCuenta;
            this.edad = edad;
            this.dni = dni;
            this.lugarDeNacimiento = lugarDeNacimiento;
            this.lugarDeProcedencia = lugarDeProcedencia;
            this.carreraEstudiantil = carreraEstudiantil;
            this.asistioAClases = asistioAClases;
        }

        public bool AsistenciaEnClase()
        {
            if (asistioAClases == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }
        public bool NacimientoProcedenciaIgual()
        {
            return lugarDeNacimiento.Equals(lugarDeProcedencia);
        }
    }
}
