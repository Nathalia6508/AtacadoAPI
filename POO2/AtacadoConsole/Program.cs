namespace AtacadoConsole;

using Atacado.BD.EF.Database;

public class Program
{
    public static void Main(string[] args)
    {
        AtacadoContext contexto = new AtacadoContext();

        /*
        foreach (Categorium item in contexto.Categoria.ToList())
        {
            Console.WriteLine($"{item.Codigo} - {item.Descricao}");
        }
        */

        /*
        foreach (Regiao item in contexto.Regioes)
        {
            Console.WriteLine($"{item.CodigoRegiao} - {item.Nome}");
        }
        */

        /*
        foreach (Estado item in contexto.Estados)
        {
            Console.WriteLine($"{item.CodigoEstado} - {item.Nome}");
        }
        */

        foreach (Cidade item in contexto.Cidades)
        {
            Console.WriteLine($"{item.CodigoCidade} - {item.Nome}");
        }

        Console.ReadLine();
    }
}