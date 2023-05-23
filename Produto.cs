using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        public List<Produto> ListaDeProdutos = new List<Produto>();
        
        public void Cadastrar()
        {
            Console.Clear();
            Produto produto = new Produto();

            Console.WriteLine($"Codigo do produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nome do produto:");
            produto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Nome marca:");
            produto.Marca.NomeMarca = Console.ReadLine();
            
            Console.WriteLine($"Codigo marca:");
            produto.Marca.Codigo = int.Parse(Console.ReadLine());

            produto.DataCadastro = DateTime.Now;
            produto.CadastradoPor = new Usuario();
        
            ListaDeProdutos.Add(produto);
        
        }
        
        public void Listar()
        {
            // LISTAR OS OBJETOS CADASTRADOS
            Console.Clear();
            Console.WriteLine($"Produtos cadastrados:");
            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine(@$"
                Codigo do produto: {item.Codigo} 
                Nome do produto: {item.NomeProduto}
                Preço do produto: {item.Preco:F2}
                Data de cadastro do produto: {item.DataCadastro}
                Nome da marca: {item.Marca.NomeMarca}
                Código da marca: {item.Marca.Codigo}
                ");
                // COLOCAR POR QUEM FOI CADASTRADO
            }
        }
        
        public string Deletar(int codigo)
        {
            Produto encontrarProduto = ListaDeProdutos.Find(x => x.Codigo == codigo);

            if (encontrarProduto !=null)
            {
                
                // DELETAR OBJETO
                Console.Clear();
                ListaDeProdutos.Remove(encontrarProduto);
                Console.WriteLine($"Produto removido com sucesso!");
                
                
            }
            else 
            {
                Console.WriteLine($"Produto não encontrado!");
                
            }
            
            return"";
        }
    }
}