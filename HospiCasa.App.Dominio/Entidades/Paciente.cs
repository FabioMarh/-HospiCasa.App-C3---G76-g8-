using System;

namespace HospiCasa.App.Dominio
{
    public class Paciente : Persona
    {

        public int? id {get;set;}
        public int pacienteid{get;set;}
        public string direccion {get;set;}
        public int direccionGeorreferenciada {get;set;}
        public string ciudad {get;set;}
        public DateTime fechaNacimiento {get;set;}

        //Relacion uno a muchos Familiar paciente ---- parece funcionar sin esta parte...
                // public Familiar familiar {get;set;}
        //Lo que quiere decir que tal vez funcione así para clase historia y clase paciente... so:  ..

        public HistoriaMedica historiaMedica {get;set;}

        //Cruza los dedos por mi .......... Parece que funciono 
        
    }
}