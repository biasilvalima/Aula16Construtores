using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sem argumentos
            Produto sapato = new Produto();

            //Instancia da sobrecarga do metodo construtor com 1 metodo
            Produto sapatilha = new Produto("vermelho");
            System.Console.WriteLine(sapatilha.Cor);

            System.Console.WriteLine();

            Produto tenis = new Produto("Vans", "Preto");
            System.Console.WriteLine(tenis.Nome);
            System.Console.WriteLine(tenis.Cor);

            System.Console.WriteLine();

            //Instancia da sobrecarga com todos os metodos
            Produto chinelo = new Produto(441, "Havaianas", "ótimo para dias quentes", "Vermelho");
            System.Console.WriteLine(chinelo.Codigo);
            System.Console.WriteLine(chinelo.Nome);
            System.Console.WriteLine(chinelo.Descricao);
            System.Console.WriteLine(chinelo.Cor);

           

            
        }
    }
}
