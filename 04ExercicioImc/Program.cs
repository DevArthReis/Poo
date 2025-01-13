namespace _04ExercicioImc
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.nome = Console.ReadLine();
            obj.peso = float.Parse(Console.ReadLine());
            obj.altura =float.Parse(Console.ReadLine());
            Console.WriteLine($"Nome: {obj.nome}");
            Console.WriteLine($"Peso: {obj.peso} kg");
            Console.WriteLine($"Altura: {obj.altura} m");
            double imc = obj.CalcularIMC();
            Console.WriteLine($"IMC: {imc:F2}");
            if (imc < 18.5f)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Obesidade 1");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade 2");
            }
            else
            {
                Console.WriteLine("Obesidade 3");
            }



        }
    }
}
