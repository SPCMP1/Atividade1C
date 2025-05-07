/* 🔷 Classe Professor (herda de Pessoa)

Atributos:
● Registro (string)
● SalarioBase (double)
● HorasExtras (int)

Métodos:
● CalcularSalarioFinal() → salário final = salário base + (horas extras * 40)
● PodeSeAposentar() → retorna true se idade > 60
● CalcularAposentadoria() → retorna 75% do salário final */

namespace C__Escola
{
    public class Professor : Pessoa
    {
        private string Registro { get; set; }
        private double SalarioBase { get; set; }
        private int HorasExtras { get; set; }
        private double salarioFinal{get; set;}

        public Professor(string nome, int idade,string registro, double salarioBase, int horasExtras) :base( nome,idade)
        {
            this.Registro = registro;
            this.SalarioBase = salarioBase;
            this.HorasExtras = horasExtras;
            
        }

        public double CalcularSalarioFinal(){
            salarioFinal = 0;
            salarioFinal = SalarioBase + (HorasExtras * 40);

            return salarioFinal;
        }

        public bool PodeSeAposentar(){
            if( this.idade >= 60)
            return;
        }

        public Double CalcularAposentadoria
    };
}