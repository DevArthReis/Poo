class Aluno
{
   //Atributos
   private double nota1,nota2;
   private double media()
   {
    return (nota1 +nota2)/2;
   }
   public void mensagem()
   {
    Console.WriteLine("Informe a primeira nota");
    nota1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a segunda nota");
    nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine($"A media do aluno é {media()} ");

   }
}