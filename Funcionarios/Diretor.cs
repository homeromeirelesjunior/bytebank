using Bytebank.SistemasInterno;

namespace Bytebank.Funcionarios
{
  public class Diretor : Autenticavel
  {
    public Diretor(string nome, string cpf) : base(nome, cpf, 5000)
    {

    }

    public override double getBonificacao()
    {
      return Salario * 0.5;
    }

    public override void AumentarSalario()
    {
      this.Salario *= 1.15;
    }
  }
}