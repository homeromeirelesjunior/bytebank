namespace Bytebank.Funcionarios
{
  public abstract class Funcionario
  {
    public Funcionario(string nome, string cpf, double salario)
    {
      this.Nome = nome;
      this.Cpf = cpf;
      this.Salario = salario;
      totalDeFuncionarios += 1;
    }
    public string Nome { get; set; }
    public string Cpf { get; private set; }
    public double Salario { get; protected set; }
    public static int totalDeFuncionarios { get; private set; }
    public abstract double getBonificacao();
    public abstract void AumentarSalario();
  }
}