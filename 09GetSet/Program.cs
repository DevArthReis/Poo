﻿namespace _09GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.Nome=Console.ReadLine();//Set recebe o valor e armazena
            obj.Senha=double.Parse(Console.ReadLine());
            Console.WriteLine(obj.Nome);//Get obtém o valor armazenado e envia o valor para a tela do console.
            Console.WriteLine(obj.Senha);
        }
    }
}