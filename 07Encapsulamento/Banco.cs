class Banco
{
    //exercicio que eu fiz pra treinar o encapsulamento 
    private int numeroconta;
    private double saldo;
    private double saque;
    private double op;
    public void menu()
    {
        Console.WriteLine("O que desejas fazer: ");
        Console.WriteLine("Digite 1 se quer depositar");
        Console.WriteLine("Digite 2 se quer sacar");
        op = int.Parse(Console.ReadLine());
        
        
        if(op == 1 ){
            depositar();
        }
        if(op == 2 )
        {
            sacar();
        }

    }
    public void depositar(){
        Console.WriteLine("Qual o numero da conta que desejas adicionar saldo:  ");
        numeroconta = int.Parse(Console.ReadLine());
        Console.WriteLine("Quanto quer adicionar nesta conta: ");
        saldo = double.Parse(Console.ReadLine());
        Console.WriteLine($"A conta {numeroconta} tem o saldo de {saldo}");
        
    }
    public void sacar()
    {
        Console.WriteLine("Qual o numero da conta que desejas adicionar saldo:  ");
        numeroconta = int.Parse(Console.ReadLine());
        Console.WriteLine("Quanto deseja sacar: ");
        saque = double.Parse(Console.ReadLine());
        saldo = saque - saldo;
        Console.WriteLine($"Vc sacou da conta numero:{numeroconta} o total de {saque}");
    }
    
}