using System;

namespace HospiCasa.App.Dominio
{
    public class Familiar : Persona
    {
        public int? id {get;set;}
        public int familiarid {get;set;}
        public string correo {get;set;}
        public string parentescoPaciente {get;set;}

        //Relacion uno a uno paciente Familiar
        //public int idPaciente {get;set;}
        /*public int idPaciente {get;set;}
        public Paciente paciente {get;set;}*/
        public Paciente paciente {get;set;}
        


    }

}