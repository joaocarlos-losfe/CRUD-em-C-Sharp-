using System;
using System.Linq;
using System.Security.Cryptography;

namespace DiamondsCacts
{
    class Program
    {
        
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
                foreach (string menu in menu_opcoes)
                {
                    Console.Write("" + menu + " ");
                }

                Console.WriteLine(". Selecione as teclas \" PgUp\"  \"PgDn \" para selecionar uma opção..");

                Console.WriteLine();

                Console.WriteLine();

                Console.Write("Opção selecionada: [" + menu_opcoes[menu_passo] + "] ");

                var key_pressed = Console.ReadKey(true).Key.ToString();
                
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
             

            }
            
        }

        
    }
}
