using Bytebank.Funcionarios;

namespace Bytebank.Utilitarios
{
  public class GerenciadorDeBonificacao
  {
    private double totalBonificacao;

    public void Registrar(Funcionario funcionario)
    {
      this.totalBonificacao += funcionario.getBonificacao();
    }

    public double getBonificacao()
    {
      return this.totalBonificacao;
    }
  }
}