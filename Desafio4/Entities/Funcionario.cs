namespace Desafio4.Entities
{
    public abstract class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public double Salario { get; set; }
    }
}