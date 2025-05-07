/* 🔷 Classe Pessoa (classe base)
Atributos privados:
● Nome (string)
● Idade (int)

Implemente os getters e setters para os atributos. */

namespace C__Escola
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
    };
}