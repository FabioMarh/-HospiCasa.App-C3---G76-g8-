using System;

namespace HospiCasa.App.Dominio
{
    public class HistoriaMedica
    {
        public int id {get;set;}
        public string diagnostico {get;set;}
        public string entornoHospitalizacion {get;set;}

        //Relacion uno a muchos -- muchas historias por medico 
        public int idMedico {get;set;}
        public Medico medico {get;set;}

        //Relacion uno a muchos con sugerencia de cuidado 
        public List <SugerenciaCuidado> listaDeSugerencias {get;set;}

        //Relacion de uno a muchos con signo vital 
        public List <SignoVital> listadeSignos {get;set;}


    
    }
}