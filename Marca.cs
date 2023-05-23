using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; private set; }
        public List<Marca> ListaDeMarcas = new List<Marca>();
      
        public void Cadastrar()
        {
            Marca marca = new Marca();
            
            Console.WriteLine($"Informe o código da marca:");
            marca.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Informe o nome da marca:");
            marca.NomeMarca = Console.ReadLine();
           
            ListaDeMarcas.Add(marca);

            
        }
        public void Listar()
        {
            // LISTAR OS OBJETOS CADASTRADOS
            Console.Clear();
            Console.WriteLine($"Marcas cadastradas:");
            foreach (Marca item in ListaDeMarcas)
            {
                Console.WriteLine(@$"
                Codigo da marca: {item.Codigo} 
                Nome da marca: {item.NomeMarca}
                Data de cadastro da marca:{item.DataCadastro.ToShortDateString()}
                
                ");
                
            }
        }
        public string Deletar(int codigo)
        {
            // BUSCAR O OBJETO NA LISTA PELO CODIGO
            // FUNÇÃO LAMBDA
            Marca encontrarMarca = ListaDeMarcas.Find(x => x.Codigo == codigo);

            if (encontrarMarca !=null)
            {
                // DELETAR OBJETO
                Console.Clear();
                ListaDeMarcas.Remove(encontrarMarca);
                Console.WriteLine($"Marca removida com sucesso!");
                
                
            }
            else 
            {
                Console.WriteLine($"Marca não encontrada!");
                
            }
            
            
            return "0"; 
        }
        
        
    }
}