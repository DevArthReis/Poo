class Pessoa{
//atributos
public string nome;
public int idade;
//metodo
public void mensagem()
{
    Console.WriteLine("Ola "+nome+" vc ja esta com "+idade+" anos");
}
public void multa(){
    if(idade<18){
        Console.WriteLine(nome+" devera pagar uma multa de 100 reais Idade: "+idade+" Menor que o permitido");
    }
    else{
        Console.WriteLine(nome+" Esta permitido  dirigir ");
    }
}
}
