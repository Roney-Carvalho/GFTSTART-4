namespace Desafio4.Entities
{
    public class Gerente : Funcionario
    {
        
        public double Bonificacao(double salario)
    {
        double SalarioFinal = salario =+ 10000;
        return 0.0;
    }
    }
}