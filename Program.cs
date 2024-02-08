
using System;
public class Program
{
    public static void Main(string[] args)
    {
       Perro perro = new Perro();
       perro.ladrar();
       perro.caminar();
       
       Pug pug = new Pug();
       pug.Especie = "Perro";
       pug.sufrir();
       
    }
}

public class Animal
{
    public string Especie;
}

public class Perro : Animal 
{
    public void ladrar()
    {
        Console.WriteLine("Perro ladra");
    }
    public void caminar()
    {
        Console.WriteLine("Perro camina");
    }
}

public class Pug : Perro{
    public void sufrir()
    {
        Console.WriteLine("Pug no sabe respirar");
    }
  
}

