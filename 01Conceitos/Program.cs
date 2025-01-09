//using é quando eu vou importar algum arquivo
namespace _01Conceitos//namespace = pasta do arquivo
{ // 
    class Program
    {
    static void Main(string[] args)//todo projeto tem que ter um static void main 
    {//o Main é o arquivo principal de todo projeto
       //instanciando um obj
       Pessoa obj = new Pessoa();
       obj.idade = 20;
       obj.nome = "Arthur";
       obj.mensagem();
       obj.multa();
       //instanciado outro obj
       Pessoa novoobj = new Pessoa();
       novoobj.idade = 16;//colocando idade ao atributo
       novoobj.nome = "Julia";//colocando nome ao atributo
       novoobj.mensagem();//aqui esta sendo chamado o metodo
       novoobj.multa();
       //instanciado umm obj  como novo metodo e novo atributo
       Carro objcarro = new Carro();
       objcarro.nome = "CIVIC";
       objcarro.placa = 99993821;
       objcarro.resumo();
       Usuario Objeto = new Usuario();
       Objeto.name = "Arthu";
       Objeto.id = 01;
       Objeto.password = "arthur1234";
       Objeto.email = "Arthur@gmail.com";
       Objeto.resumo();
       
       

    }

    }
}