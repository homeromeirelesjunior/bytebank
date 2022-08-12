using System;
using Bytebank.Funcionarios;
using Bytebank.Utilitarios;
using Bytebank.SistemasInterno;

namespace Bytebank
{
  class Program
  {
    static void Main(string[] args)
    {
      // GerenciadorDeBonificacao();
      // UsarSistema();

      void GerenciadorDeBonificacao()
      {
        Console.WriteLine("Bem vindo(a) ao ByteBank!");

        GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

        Designer jorge = new Designer("Jorge Carlos", "123.456.789-95");

        Diretor ana = new Diretor("Ana Karla Honório", "987.654.321-98");

        Desenvolvedor homero = new Desenvolvedor("Homero Junior", "465.789.123-58");

        Console.WriteLine("Bonificação: " + jorge.getBonificacao());
        Console.WriteLine("Bonificação: " + ana.getBonificacao());

        gerenciador.Registrar(jorge);
        gerenciador.Registrar(ana);
        gerenciador.Registrar(homero);

        Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());

        Console.WriteLine(Funcionario.totalDeFuncionarios);

      }

      void UsarSistema()
      {
        SistemaInterno sistemaInterno = new SistemaInterno();

        Diretor roberta = new Diretor("Roberta Solas", "358.123.456-78");
        roberta.Senha = "123";
        roberta.Login = "Boss";

        Designer beto = new Designer("Beto Bombom", "123.789.852-78");

        sistemaInterno.Logar(roberta, roberta.Login, roberta.Senha);
      }
    }
  }
}
