using System;

namespace HospiCasa.App.Dominio
{
    public class Medico : Persona
    {
        public int id {get;set;}

        public int registroReTHUS {get;set;}
        public string especialidad {get;set;}

        //Relacion uno a muchos Con un medico muchas historias 

        public List <HistoriaMedica> listaHistorias {get;set;}
        

    }
}