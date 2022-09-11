// See https://aka.ms/new-console-template for more information
using System;
//Segun la guia del programa en mintic
using Linq;
using HospiCasa.App.Persistencia;
using HospiCasa.App.Dominio;

public class Program 
{
    private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente (new HospiCasa.App.Persistencia.AppContext() );
    private static void Main (string [] args)
    {
        Console.WriteLine ("Hola Mundo .NET");
        AdicionarPaciente();
    }
    
    static void AdicionarPaciente()
    {
        Console.WriteLine ("Adicionar un paciente ... ");
        Paciente paciente = new Paciente ();
        
        //Experimento Agregar atributos clase padre (Persona)
        paciente.id = 1111166845;
        paciente.Nombre = "Albeiro";
        paciente.Apellidos = "Sanchez Urrutia";
        paciente.NumeroTelefono = "3165024598";
        paciente.Genero = Genero.masculino;
        paciente.tipoId = TipoId.Cedula;


        //Atributos propios de la clase paciente
        paciente.idPaciente = 001;
        paciente.direccion = "Cll falsa N 123";
        paciente.direccionGeorreferenciada = 025 - 563;
        paciente.ciudad = "Cali";
        paciente.fechaNacimiento = DateTime.Now;

        

           

        _repositorioPaciente.AddPaciente(paciente);
        Console.WriteLine ("Usuario adicionado satisfactoriamente");
         
    }
}

