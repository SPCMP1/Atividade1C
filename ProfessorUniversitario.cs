/* 🔷 Classe ProfessorUniversitario (herda de Professor)
● Aposenta-se com mais de 65 anos
● Aposentadoria = 75% do salário final + R$ 1.000,00 de bônus */

namespace C__Escola
{
    public class ProfessorUniversitario : Professor
    {
        public ProfessorUniversitario(string nome, int idade, string registro, double salarioBase, int horasExtras) : base(nome, idade, registro, salarioBase, horasExtras)
        {

        }

        public bool PodeSeAposentar(){
            if( this.idade >= 60)
            return;
        }

        
    }
}