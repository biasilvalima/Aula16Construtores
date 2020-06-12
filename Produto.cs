namespace Aula16Construtores
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        
        public string Cor { get; set; }


        //Com os construtores aplicamos o proprio nome da classe
        public Produto(){

        }

        public Produto(string _cor){
            this.Cor = _cor;
        }

        public Produto(string _nome, string _cor){
            this.Nome = _nome;
            this.Cor = _cor;
        }

        //Usamos o _ pra diferenciar do metodos de fora e o this pra identifcar qual estamos usando
        public Produto(int _codigo, string _nome, string _descricao, string _cor){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Descricao = _descricao;
            this.Cor = _cor;
        }

    }
}