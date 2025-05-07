/* 🔷 Classe ProfessorEnsinoBasico (herda de Professor)
● Aposenta-se com mais de 55 anos
● Aposentadoria = 90% do salário final */

namespace C__Escola
{
    public class ProfessorEnsinoBasico : Professor
    {
        public ProfessorEnsinoBasico(string nome, int idade, string registro, double salarioBase, int horasExtras) : base(nome, idade, registro, salarioBase, horasExtras)
        {

        }

        public bool PodeSeAposentar(){
            if( this.idade >= 60)
            return;
        }

        
    }
}