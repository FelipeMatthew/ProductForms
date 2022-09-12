public class Produto
{
    //atributos
    public int id;
    public string nome;
    public int qtd_estoque;
    public float preco;

    //metodos
    public Produto()
    {
        this.id = 0;
        this.nome = "";
        this.qtd_estoque = 0;
        this.preco = 0;
    }

    //metodo construtor
    public Produto(int p_id, string p_nome, int p_qtd_estoque, float p_preco) //quando o metodo tem o mesmo nome da classe ele é um metodo construtor
    {
        this.id = p_id;
        this.nome = p_nome;
        this.qtd_estoque = p_qtd_estoque;
        this.preco = p_preco;
    }
}
