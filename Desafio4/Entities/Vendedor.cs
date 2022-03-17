namespace Desafio4.Entities
{
    public class Vendedor : Funcionario
    {
        public double Bonificacao(double salario)
    {
        double SalarioFinal = salario + 3000;
        return 0.0;
    }
    }
}