class Pessoa
{
    public string nome;
    public float peso;
    public float altura;
    public double CalcularIMC()
    {
        return peso / (altura * altura);
    }
    
}