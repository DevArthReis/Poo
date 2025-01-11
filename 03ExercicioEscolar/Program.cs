namespace _03ExercicioEscolar
{
    class Program
    {
        // Instanciar objeto da classe Aluno
        static void Main(string[] args)
        {
            Aluno Obj = new Aluno();
            Console.WriteLine("Digite seu nome: ");
            Obj.nome = Console.ReadLine();//Ex: Obj.nome = "ARTHUR";
            Console.WriteLine("Digite sua nota 1: ");
            Obj.nota1 = float.Parse(Console.ReadLine());//Ex: Obj.nota1 = 10; 
            Console.WriteLine("Digite sua nota 2: ");
            Obj.nota2 = float.Parse(Console.ReadLine());//Ex: Obj.nota2 = 5;
            Obj.mensagem();//Ex: Arthur está Reprovado com a média 6

        }
    }
}

