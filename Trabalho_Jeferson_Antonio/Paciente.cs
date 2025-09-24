using System;

namespace projetohosp
{
    public class Paciente
    {
        public Pessoa[] fila = new Pessoa[15];
        public int numeroDePacientes = 0;

        public void CadastrarPaciente()
        {
            if (numeroDePacientes >= 15)
            {
                Console.WriteLine("A fila está cheia!");
                return;
            }

            Pessoa novo = new Pessoa();
            Console.Write("Nome do paciente: ");
            novo.Nome = Console.ReadLine();
            Console.Write("Preferencial? (1 = sim, 0 = nao): ");
            novo.Preferencial = int.Parse(Console.ReadLine());

            int ponto = 0;
            if (novo.Preferencial == 1)
            {
                while (ponto < numeroDePacientes && fila[ponto].Preferencial == 1) ponto++;
                for (int i = numeroDePacientes; i > ponto; i--) fila[i] = fila[i - 1];
                fila[ponto] = novo;
            }
            else fila[numeroDePacientes] = novo;

            numeroDePacientes++;
            Console.WriteLine("Paciente cadastrado!");
        }

        public void ListarPacientes()
        {
            if (numeroDePacientes == 0)
            {
                Console.WriteLine("Fila vazia.");
                return;
            }

            int i = 0;
            while (i < numeroDePacientes)
            {
                string status;
                if (fila[i].Preferencial == 1)
                    status = "[PREFERENCIAL]";
                else
                    status = "[COMUM]";

                Console.WriteLine((i + 1) + ". " + fila[i].Nome + " " + status);
                i++;
            }
        }

        public void AtenderPaciente()
        {
            if (numeroDePacientes == 0)
            {
                Console.WriteLine("Nao ha pacientes.");
                return;
            }

            Console.WriteLine("Atendendo: " + fila[0].Nome);
            for (int i = 0; i < numeroDePacientes - 1; i++) fila[i] = fila[i + 1];
            numeroDePacientes--;
        }

        public void AlterarPaciente()
        {
            if (numeroDePacientes == 0)
            {
                Console.WriteLine("Fila vazia.");
                return;
            }

            ListarPacientes();
            Console.Write("Numero do paciente: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0 || num > numeroDePacientes)
            {
                Console.WriteLine("Numero invalido.");
                return;
            }

            int indice = num - 1;
            Pessoa p = fila[indice];
            Console.Write("Novo nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preferencial? (1 = sim, 0 = nao): ");
            p.Preferencial = int.Parse(Console.ReadLine());

            for (int i = indice; i < numeroDePacientes - 1; i++) fila[i] = fila[i + 1];
            numeroDePacientes--;

            int ponto = 0;
            if (p.Preferencial == 1)
            {
                while (ponto < numeroDePacientes && fila[ponto].Preferencial == 1) ponto++;
                for (int i = numeroDePacientes; i > ponto; i--) fila[i] = fila[i - 1];
                fila[ponto] = p;
            }
            else fila[numeroDePacientes] = p;

            numeroDePacientes++;
            Console.WriteLine("Paciente alterado.");
        }
    }
}
