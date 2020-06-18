using System;
using System.Linq;
using System.Security.Cryptography;

namespace DiamondsCacts
{
    class Program
    {
        public struct RG
        {
            string registro_geral;
            DateTime data_espedicao;
            string nome_mae;
            string nome_pai;
            string naturalidade;
            DateTime datanascimento;
        }
        public struct Pessoa 
        {

            string nome;
            int idade;
            float altura;
            string cpf;

            RG rg;
        }

        static void Main(string[] args)
        {

            string[] menu_opcoes = new string[] 
            {
                " Cadastrar",
                " Listar   ",
                " Buscar   ",
                " Alterar  ",
                " Remover  "
            };

            int menu_passo = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Informações de pessoas. CRUD em C#\n");

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
                
                if(key_pressed.Equals("DownArrow"))
                {
                    menu_passo++;

                    if (menu_passo > 4) //nao avançar no menu
                    {
                        menu_passo--;
                    }
                    
                }

                if(key_pressed.Equals("UpArrow"))
                {
                    menu_passo--;
                    if (menu_passo < 0) //nao retroceder no menu
                    {
                        menu_passo++;
                    }
                    
                }

                if(key_pressed.Equals("Enter"))
                {
                    Console.WriteLine(menu_opcoes[menu_passo]);
                    switch (menu_passo)
                    {
                        case 0:
                            
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

