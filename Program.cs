using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.CompilerServices;

namespace DiamondsCacts
{
    class Program
    {

        public struct Contato
        {
            public string nome;
            public string telefone;
            public string email;

        }
        public static void salvar_arquivo(int id, string nome, string telefone, string email)
        {
            StreamWriter arquivo_add;
            //StreamReader arquivo_read;

            using (arquivo_add = File.AppendText("data.dat"))
            {
                arquivo_add.WriteLine("{0} {1} {2} {3};", id, nome, telefone, email);
                Console.WriteLine("salvo...enter para continuar...");
                Console.ReadKey();
            }
        }

        public static void ler_do_arquivo_para_memoria(List<string> lista_de_contatos)
        {
            string[] temp_contatos = File.ReadAllLines("data.dat");

            int count = 1;

            foreach (string contatos in temp_contatos)
            {
                Console.Write("\r aguarde.. {0}", count);
                lista_de_contatos.Add(contatos);
                count++;
            }
        }

        public static void cadastrar(ref int id)
        {
            Console.WriteLine();

            Contato contato;

            Console.WriteLine("Nome: ");
            contato.nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("telefone: ");
            contato.telefone = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("email: ");
            contato.email = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("{0} {1} {2}", contato.nome, contato.telefone, contato.email);

            Console.WriteLine();

            Console.WriteLine("1 - salvar 0 - cancelar");
            int confirma = Convert.ToInt32( Console.ReadLine() );

            if(confirma == 1)
            {
                salvar_arquivo(id, contato.nome, contato.telefone, contato.email);
                id++;
            }
            else
            {
                Console.WriteLine("Descartado...");
            }

        }
        
        static void Main(string[] args)
        {
            List<string> contatos_list = new List<string>(); 
           
            int id = 0;

            if ( !File.Exists("data.dat") )
            {
                File.CreateText("data.dat");
                Console.WriteLine("Arquivos criado com sucesso...");
            }
            else
            {
                Console.WriteLine("Um arquivo data.dat ja existe..");
            }

            ler_do_arquivo_para_memoria(contatos_list); // trazer tudo do arquivo para a memoria

            Console.ReadKey();

            string[] menu_opcoes = new string[]
            {
                "Cadastrar ",
                "Listar    ",
                "Buscar    ",
                "Alterar   ",
                "Remover   "
            };

            
            Console.Write("enter para iniciar..");
            Console.ReadKey();

            int menu_passo = 0;

            while (true)
            {
                Console.Clear();

                foreach (string menu in menu_opcoes)
                {
                    Console.Write("" + menu + " ");
                }

                Console.WriteLine(". Selecione as teclas \" PgUp\"  \"PgDn \" para selecionar uma opção..");

                Console.WriteLine();

                Console.WriteLine();

                Console.Write("Opção selecionada: [" + menu_opcoes[menu_passo] + "] ");

                var key_pressed = Console.ReadKey(true).Key.ToString();

                    //Console.WriteLine(key_pressed);

                if (key_pressed.Equals("DownArrow"))
                {
                    menu_passo++;

                    if (menu_passo > 4) //nao avançar no menu
                    {
                        menu_passo--;
                    }

                }

                if (key_pressed.Equals("UpArrow"))
                {
                    menu_passo--;
                    if (menu_passo < 0) //nao retroceder no menu
                    {
                        menu_passo++;
                    }

                }

                if (key_pressed.Equals("Enter"))
                {
                    Console.WriteLine();
                    Console.WriteLine(menu_opcoes[menu_passo]);
                    switch (menu_passo)
                    {
                        case 0:
                            cadastrar(ref id);
                            break;

                        case 1:
                            break;
                        case 2:
                            break;

                         case 3:
                            break;

                         case 4:
                            break;
                        }


                }

            }

        }


    }
    
}

