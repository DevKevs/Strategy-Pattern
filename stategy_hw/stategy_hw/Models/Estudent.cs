using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stategy_hw.Models
{
    public class Estudent
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Carrera { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int Save_Option { get; set; }
        public override string ToString()
        {
            return $"ESTUDIANTE\nNombre:{Nombre}\nApellidos: {Apellidos}\nMatricula: {Matricula}\nCarrera: {Carrera}\nDireccion: {Direccion}\nTelefono: {Telefono}\nEmail: {Email}";
        }
    }
}