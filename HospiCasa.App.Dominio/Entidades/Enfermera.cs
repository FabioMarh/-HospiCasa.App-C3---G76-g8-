
using System;

namespace HospiCasa.App.Dominio
{
    public class Enfermera : Persona
    {
        //Key
        public int idEnfermera {get;set;}

        //Atributos de la clase 
        public int targetaProfecional {get;set;}
        public string horasLaboralesSemana {get;set;}

        //Relacion uno a muchos un enfermero muchos signos vitales 
        public List <SignoVital> signosVitales {get;set;}

    }
}
