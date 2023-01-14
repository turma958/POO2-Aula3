//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//var customers = GetCustomers();

//var count = customers.Count();
//Console.WriteLine(count);

//foreach (var item in customers)
//{
//    Console.WriteLine($"{item.Name} - {item.Age}");
//}

//Console.ReadLine();

//IEnumerable<Customer> GetCustomers()
//{
//    // Colocar na pasta bin/Debug/.net6
//    var lines = File.ReadAllLines("./customers.csv");

//    var lista = new List<Customer>();

//    //foreach (var line in lines)
//    //{
//    //    var data = line.Split(',');
//    //    yield return new Customer(data[0], Convert.ToInt32(data[1]));
//    //}

//    //return lines.Select(x =>
//    //{
//    //    var data = x.Split(',');
//    //    return new Customer(data[0], Convert.ToInt32(data[1]));
//    //});

//    foreach (var line in lines)
//    {
//        var data = line.Split(',');
//        var customer = new Customer(data[0], Convert.ToInt32(data[1]));
//        lista.Add(customer);
//    }

//    return lista;
//}

//public record Customer(string Name, int Age);



////string[] nomes = new string[]
////{
////    "Davi", "Paulo", "Andre"
////};
////List<string> listaNomes = new List<string>
////{
////    "Davi", "Paulo", "Andre"
////};
////Queue<string> filaNomes = new Queue<string>();
////filaNomes.Enqueue("Davi");

////ProcessarAlunos(nomes);
////ProcessarAlunos(listaNomes);
////ProcessarAlunos(filaNomes);

////void ProcessarAlunos(IEnumerable<string> nomes)
////{

////}