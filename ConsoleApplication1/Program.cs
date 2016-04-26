using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de dados
            int valor1 = 10;
            int valor2;
            char sexo = 'M';
            string nome = "Lucas";
            float nota = 7.5f;
            double nota1 = 7.7d; //é o mais utilizado e não precisa do "d" no final.
            decimal nota2 = 7.7m;
            bool maiorDeIdade = true;


            //Entrada e saida de dados via Console

            string pergunta1 = "Qual é seu nome ? ";
            Console.Write(pergunta1);
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nome);
           
            //Estrura de decisão
            if (nome == "Lucas")
            {
                Console.WriteLine("Você é o Lucas");
            } else if(nome == "João")
            {
                Console.WriteLine("Você é o João");
            }
            else
            {
                Console.WriteLine(nome + " não é conhecido pelo sistema.");
            }



            //Arrays
            string[] nomes = new string[3];
            nomes[0] = "Lucas";
            nomes[1] = "João";
            nomes[2] = "Pedro";
            Console.WriteLine(nomes[0] + nomes[1] + nomes[2]);
            int[] numeros = new int[] { 10, 20, 30};
            Console.WriteLine(numeros[0] + numeros[1] + numeros[2]);

            //Listas = List

            List<string> listaDePessoas = new List<string>()
            {
                "João",
                "Maria"
            };

            listaDePessoas.Add("José");
            listaDePessoas.Add("Lucas");

            Console.WriteLine(listaDePessoas[0] + listaDePessoas[1]);

            //For
            int countPessoas = listaDePessoas.Count;
            Console.WriteLine("Quantidade de pessoas " + countPessoas);
            for (int i = 0; i < countPessoas; i++)
            {
                Console.WriteLine("Indice do FOR é: " + i + " seu valor é: " + listaDePessoas[i]);
            }

            //Foreach
            Console.WriteLine("Lista de pessoas com Foreach"); 
            foreach (string i in listaDePessoas)
            {
                Console.WriteLine(i);
            }

            //While
            Console.WriteLine("While com C#");
            int contador = 10;

            while (contador > 0)
            {
                Console.WriteLine("olá " + contador);
                if (contador == 5)
                {
                    break;
                }
                contador--;
            }


            Console.WriteLine("------------------------");
            Console.WriteLine("Sistema com Banco de Dados");
            Console.WriteLine("------------------------");

            BancoDeDados Db = new BancoDeDados();

            Db.abrir();

            Db.preparar("select * from usuario");

            MySql.Data.MySqlClient.MySqlDataReader usuario = Db.executar();

            while (usuario.Read())
            {
                Console.WriteLine(usuario["id"].ToString());
                Console.WriteLine(usuario["nome"].ToString());
                Console.WriteLine(usuario["email"].ToString());
                Console.WriteLine(usuario["senha"].ToString());

            }

            Db.fechar();

            

            string opcao = "";
             
            do
            {
                Console.WriteLine("Escolha a opção ou EXIT para sair.");
                Console.WriteLine("I - Inserir");
                Console.WriteLine("A - Atualizar");
                Console.WriteLine("------------------------");
                opcao = Console.ReadLine();
              

                switch (opcao)
                {
                    case "I":
                        Console.WriteLine("Inserir um registro.");
                        break;
                    default:
                        Console.WriteLine("A opção não existe!");
                        break;
                }

                Console.WriteLine("------------------------");

            } while (opcao != "EXIT");



        }

}
}
