/* 🔷 Classe Aluno (herda de Pessoa)
Atributos:
● Matricula (string)
● List<double> Notas

Métodos:
● AdicionarNota(double nota)
● Sobrecarga: AdicionarNota(double nota1, double nota2) → adiciona
duas notas de uma vez
● CalcularMedia() → retorna a média das notas
● Situacao() → retorna "Aprovado" se média ≥ 7, senão "Reprovado" */

namespace C__Escola
{
    public class Aluno : Pessoa
    {
        private string Matricula { get; set; }
        private double Media { get; set; }
        private string Resultado {get; set;}
        private List<double> Notas {get; set;}
    
        public Aluno(string nome, int idade, string matricula, double media, string resultado) :base(nome,idade){
            this.Matricula = matricula;
            this.Media = media;
            this.Resultado = resultado;
            Notas = new List<double>();

        }
    
        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
        }

        public void AdicionarNota(double nota1, double nota2){
            Notas.Add(nota1);
            Notas.Add(nota2);
        }

        public double CalcularMedia(){
            double soma = 0;
            foreach (var nota in Notas){
                soma += nota;
                
            }
            return Media=soma / Notas.Count;
        }

        public string Situacao(){
            if(Media >= 7){
               Resultado = ("Tá vivo");
            }else{
                Resultado = ("Tá abatido");
            }
            return ($"{Resultado} e sua Média:{Media}");
        }
    
    };

}
