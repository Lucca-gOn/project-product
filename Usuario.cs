using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Usuario
    {
        public Random Codigo { get; private set; }
        public string Nome { get; set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public List<Usuario> ListaDeUsuarios = new List<Usuario>();

        public string Cadastrar()
        {
            Console.Clear();
            Usuario usuario = new Usuario();
            
            Console.WriteLine(@$"*------------------------------------*");
            Console.WriteLine(@$"*       CADASTRO DE USUÁRIO          *");
            Console.WriteLine(@$"*------------------------------------*");
            
            
            
            Console.WriteLine($"NOME COMPLETO:");
            usuario.Nome = Console.ReadLine();

            Console.WriteLine($"EMAIL:");
            Email = Console.ReadLine();
            
            Console.WriteLine($"SENHA:");
            Senha = Console.ReadLine(); 
            
            usuario.DataCadastro = DateTime.Now;
            ListaDeUsuarios.Add(usuario);
           
            return "";
        }

        public void Lista()
        {
            Console.WriteLine($"Usuarios cadastrados:");
            foreach ( Usuario item in ListaDeUsuarios)
            {
                Console.WriteLine(@$"
                Codigo: {item.Codigo}
                Nome:{item.Nome}
                Data de cadastro:{item.DataCadastro}
                ");
                Thread.Sleep(2000); 
                
            }
            
        }
       
       public string Deletar(string nome)
        {
            
            Usuario encontrarUser = ListaDeUsuarios.Find(x => x.Nome == nome);

            if (encontrarUser !=null)
            {
                // DELETAR OBJETO
                Console.Clear();
                ListaDeUsuarios.Remove(encontrarUser);
                Console.WriteLine($"Usuario removido com sucesso!");
                
                
            }
            else 
            {
                Console.WriteLine($"Usuario não encontrado!");
                
            }
            
            return "0";
        }
        
    }
}