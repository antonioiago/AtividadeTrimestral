using System;

namespace projetohospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Paciente hospital = new Paciente();
            string opcao = "";

            while (opcao != "q")
            {
                Console.WriteLine("----------Menu de escolha---------");
                Console.WriteLine("1 - Cadastre pacientes");
                Console.WriteLine("2 - Liste os pacientes");
                Console.WriteLine("3 - Atender os pacientes");
                Console.WriteLine("4 - Altere os dados dos pacientes");
                Console.WriteLine("q - Sair do programa");
                Console.Write("escolha para aonde deseja ir: ");
                opcao = Console.ReadLine();

                if (opcao == "1") hospital.CadastrarPaciente();
                else if (opcao == "2") hospital.ListarPacientes();
                else if (opcao == "3") hospital.AtenderPaciente();
                else if (opcao == "4") hospital.AlterarPaciente();
                else if (opcao == "q") Console.WriteLine("Saindo do programa...");
                else Console.WriteLine("Opcao invalida");
            }
        }
    }
}


