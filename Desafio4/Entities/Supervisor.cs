namespace Desafio4.Entities
{
    public class Supervisor : Funcionario
    {
        
        public double Bonificacao(double salario)
    {
        double SalarioFinal = salario + 5000;
        return 0.0;
    }
    }
}