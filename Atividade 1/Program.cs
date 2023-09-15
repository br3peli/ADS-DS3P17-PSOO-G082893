using System;

class Estudante
{
    public string RA { get; set; }
    public string Nome { get; set; }

    public Estudante(string ra, string nome)
    {
        RA = ra;
        Nome = nome;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e meu RA é {RA}.");
    }
}

class EstudanteGraduacao : Estudante
{
    public int AnoIngresso { get; set; }

    public EstudanteGraduacao(string ra, string nome, int anoIngresso)
        : base(ra, nome)
    {
        AnoIngresso = anoIngresso;
    }

    public void ExibirAnoIngresso()
    {
        Console.WriteLine($"Ano de ingresso: {AnoIngresso}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EstudanteGraduacao estudante = new EstudanteGraduacao("G08289-3", "Breno", 2022);

        estudante.Apresentar();
        estudante.ExibirAnoIngresso();
    }
}
