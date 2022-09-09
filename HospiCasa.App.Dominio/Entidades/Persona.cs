using System;

namespace HospiCasa.App.Dominio
{
    public class Persona
    

    {
        // intento solucion cascada y foreing key
        //public int? idPersona {get;set;}

        public int? id {get;set;}
        //public int? idPersona {get;set;}
        public String Nombre {get;set;}
        public string Apellidos {get;set;}
        public string NumeroTelefono {get;set;}
        public Genero Genero {get;set;}
        public TipoId tipoId {get;set;}



       



    }
    
}