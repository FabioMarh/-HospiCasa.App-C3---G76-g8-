using System;

namespace HospiCasa.App.Dominio
{
    public class Enfermera : Persona
    {
        //Key
        public int id {get;set;}

        //Atributos de la clase 
        public int targetaProfecional {get;set;}
        public string horasLaboralesSemana {get;set;}

        //Relacion uno a muchos un enfermero muchos signos medicos 
        public List <SignoVital> signosVitales {get;set;}

    }
}