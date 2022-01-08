using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaI
{
  class Program
  {
    static void Main(string[] args)
    {

      SortedDictionaires();

    }

    static void HashSets()
    {
      // hashsets não aceitam items repetidos
      HashSet<string> veiculos = new HashSet<string>()
      {
        "Carro",
        "Moto",
        "Avião",
        "Helicóptero",
        "Barco"
      };

      // if (veiculos.Add("Moto"))
      // {
      //   Console.WriteLine("Item adicionado");
      // }
      // else
      // {
      //   Console.WriteLine("Item não adicionado");
      // }

      // if (veiculos.Contains("Carro"))
      // {
      //   Console.WriteLine("Contém carro");
      // }
      // else
      // {
      //   Console.WriteLine("Não Contém carro");
      // }

      veiculos.Remove("Carro");
      Console.WriteLine(veiculos.Count);
      // Console.WriteLine(veiculos.ElementAt(1));

      foreach (var item in veiculos)
      {
        Console.WriteLine(item);
      }
      veiculos.Clear();
    }

    static void Lista()
    {
      // listas aceitam items repetidos
      String[] nomes = new string[3];
      nomes[0] = "Joao";
      nomes[1] = "Maria";
      nomes[2] = "Paula";
      List<String> nomes2 = new List<string>();
      String[] nomesNovos = { "Gabriel", "Josefina", "Raimunda" };
      nomes2.Add("Carlitos");
      nomes2.Add("Jamilsom");
      nomes2.Add(nomes[1]);
      nomes2.Sort();
      Console.WriteLine(nomes2[1]);
      Console.WriteLine(nomes2.Count);
      nomes2.AddRange(nomesNovos);

      // if (nomes2.Remove("Joao"))
      // {
      //   Console.WriteLine("João removido da lista");
      // }
      // else
      // {
      //   Console.WriteLine("Não foi possível remover");
      // }

      if (nomes2.Contains("Jamilsom"))
      {
        Console.WriteLine("Contém");
      }
      else
      {
        Console.WriteLine("Não Contém");
      }
      nomes2.Insert(3, "Mario");
      Console.WriteLine(nomes2.Count);
      nomes2.RemoveAt(1);
      // nomes2.Clear();
      nomes2.ForEach(nome => Console.WriteLine(nome));

      Console.WriteLine(nomes2.IndexOf("Gabriel"));
    }

    static void Dicitionaries()
    {
      Dictionary<int, string> alunos = new Dictionary<int, string>() {
        {10, "Emanuel"},
        {20, "Marcos"},
        {30, "Edna"},
      };
      alunos.Add(100, "Cristiano");
      Console.WriteLine("quantidade de alunos " + alunos.Count);
      // alunos.Remove(100);
      // alunos.Clear();
      KeyValuePair<int, string> primeiro = alunos.First();
      KeyValuePair<int, string> ultimo = alunos.Last();
      Console.WriteLine(primeiro.Value + "\n" + ultimo.Value + "\n");
      bool contem100 = alunos.ContainsKey(100);
      bool comtemMarcos = alunos.ContainsValue("Marcos");
      Console.WriteLine(comtemMarcos);
      Console.WriteLine(contem100);
      foreach (KeyValuePair<int, string> item in alunos)
      {
        Console.WriteLine(item);
      }



    }

    static void SortedLists()
    {
      SortedList<int, string> alunos = new SortedList<int, string>() {
        { 27, "Cristiano"}, {10, "Edna"}, {17, "Marcos"}, {20, "Emanuel"}
      };

      alunos.Add(14, "Glória");

      // alunos.Reverse();
      // alunos.Remove(10);
      // alunos.RemoveAt(0);
      Console.WriteLine(alunos.Count);
      Console.WriteLine(alunos.ContainsKey(50));
      Console.WriteLine(alunos.ContainsValue("Marcos") + "\n");

      foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
      {
        Console.WriteLine(aluno);
      }
    }


    static void SortedDictionaires()
    {
      SortedDictionary<int, string> alunos = new SortedDictionary<int, string>() {
        {  4512, "gabriel" },
        {  1542,  "arthur"},
        { 2145,  "danny"}
      };

      alunos.Add(5478, "flavio");

      alunos.Remove(5478);
      Console.WriteLine(alunos.Count);
      Console.WriteLine(alunos.ContainsKey(2145));
      Console.WriteLine(alunos.ContainsValue("gabriel"));

      foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
      {
        Console.WriteLine(aluno.Value + " " + aluno.Key);
      }
      Console.WriteLine(alunos.ElementAt(0).Value);
      alunos.Clear();
      Console.WriteLine(alunos);
    }


  }
}
