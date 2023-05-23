using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Login
    {
        Usuario user = new Usuario();
        public bool Logado { get; private set; }
        
        public Login() 
        {
            menuUsuario();
        }
        
        public void menuUsuario()
        {
            
            int opcao1;

            do
            {
                Console.Clear();
                Console.WriteLine($"----------------------------------------------");
                Console.WriteLine($"*              PROJETO PRODUTOS              *");
                Console.WriteLine($"----------------------------------------------");
                Console.WriteLine($"1. CADASTRAR USUÁRIO");
                Console.WriteLine($"2. EFETUAR LOGIN");
                Console.WriteLine($"0. SAIR");

                opcao1 = int.Parse(Console.ReadLine());

                switch (opcao1)
                {
                    case 1:
                        user.Cadastrar();
                        break;
                    
                    case 2:
                        Logar(user);
                        if (Logado)
                        {
                            menu();
                        }
                        break;
                    case 0:
                        Deslogar();
                        break;    

                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }
            } 
            while (opcao1 != 0);
        }

        public string Logar(Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine($"EMAIL:");
            string usuarioEmail = Console.ReadLine();
            
            Console.WriteLine($"SENHA:");
            string usuarioSenha = Console.ReadLine();
            
            if (usuario != null && user.Email == usuarioEmail && user.Senha == usuarioSenha)
            {
                Logado = true;
                Console.WriteLine($"Login efetuado com sucesso!");
                
            }
            else
            {
                Logado = false;
                Console.WriteLine($"Nenhum usuário encontrado!");
            }
            
            return "";
        }
        
        public string Deslogar()
        
        {
            Console.Clear();
            Logado = false;
            Console.WriteLine($"Usuário deslogado com sucesso!");
            return "0";
        }

        public void menu()
        {
            Produto produto = new Produto();    
            Marca marca = new Marca();
            
            int opcao2;
            
            do
            {
                Console.WriteLine($"----------------------------------------------");
                Console.WriteLine($"*              PROJETO PRODUTOS              *");
                Console.WriteLine($"----------------------------------------------");
                Console.WriteLine($"MENU PRINCIPAL");
                Console.WriteLine($"1. CADASTRAR PRODUTO");
                Console.WriteLine($"2. LISTAR PRODUTOS");
                Console.WriteLine($"3. REMOVER PRODUTOS");
                Console.WriteLine($"");
                Console.WriteLine($"4. CADASTRAR MARCA");
                Console.WriteLine($"5. LISTAR MARCA");
                Console.WriteLine($"6. REMOVER MARCA");
                Console.WriteLine($"");
                Console.WriteLine($"7. USUARIOS CADASTRADOS");
                Console.WriteLine($"8. DELETAR USUARIO");
                Console.WriteLine($"0. SAIR");
                Thread.Sleep(2000); 

                opcao2 = int.Parse(Console.ReadLine());

                switch (opcao2)
                {
                    case 1:
                        produto.Cadastrar();
                        break;
                    case 2:
                        produto.Listar();
                        break;    
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Informe o código do produto que deseja deletar:");
                        int codigoP = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoP);
                        break;
                    case 4:
                        marca.Cadastrar();
                        break;
                    case 5:
                        marca.Listar();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"Informe o código da marca que deseja deletar:");
                        int codigoM = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoM);
                        break;
                    case 7:
                        user.Lista();
                        break;  
                    case 8:
                        Console.Clear();
                        Console.WriteLine($"Informe o nome que gostaria de deletar:");
                        string nome = Console.ReadLine();
                        
                        user.Deletar(nome);
                        break;      
                    case 0:
                        Deslogar();
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }
            } while (opcao2 != 0);   
        }
    }
}
