class Aluno
{
    // Cada aluno terá atributos
    public string nome;
    public float nota1;
    public float nota2;

    // Método para calcular a média
    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    // Método para verificar a situação
    public string situacao()
    {
        return media() >= 7 ? "Aprovado" : "Reprovado";
    }

    // Mensagem
    public void mensagem()
    {
        // Obter a média
        double obterMedia = media();
        // Obter a situação
        string obterSituacao = situacao();
        // Mensagem
        Console.WriteLine(nome + " está " + obterSituacao + " com a média " + obterMedia);
    }
}