using System;

namespace projetohosp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Paciente hospital = new Paciente();
            string opcao = "";

            while (opcao != "q")
            {
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Atender");
                Console.WriteLine("4 - Alterar");
                Console.WriteLine("q - Sair");
                Console.Write("Opcao: ");
                opcao = Console.ReadLine();

                if (opcao == "1") hospital.CadastrarPaciente();
                else if (opcao == "2") hospital.ListarPacientes();
                else if (opcao == "3") hospital.AtenderPaciente();
                else if (opcao == "4") hospital.AlterarPaciente();
                else if (opcao == "q") Console.WriteLine("Saindo...");
                else Console.WriteLine("Opcao invalida");
            }
        }
    }
}
