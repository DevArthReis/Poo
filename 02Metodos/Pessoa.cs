class Pessoa
{
    //Metodo 01
    public void apresentacao()
    {
        Console.WriteLine("Ola");
    }
    //Metodo 02
    public void apresentacao(string nome)
    {
        Console.WriteLine("Ola"+nome);
    }
    //Metodo 03
    public void apresentacao(string nome,int idade)
    {
        Console.WriteLine("Ola "+nome+" Sua idade é "+idade);
    }

}