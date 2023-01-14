//using System;
//using System.Collections.Generic;
//using System.Linq;

//IOrderedCustomersCollection collection = new CustomersCollection();

//collection.Add("Davi");
//collection.Add("Andre");
//collection.Add("Guilherme");
//collection.Add("George");

//var data = collection.GetNames();
//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

//Console.ReadLine();

//interface ICustomersCollection
//{
//    void Add(string name);
//    List<string> GetNames();
//}

//interface IOrderedCustomersCollection : ICustomersCollection
//{
//    new List<string> GetNames();
//}


//class OrderedCustomersCollection : CustomersCollection, ICustomersCollection
//{
//    new public List<string> GetNames() => base.GetNames().OrderBy(x => x).ToList();
//}

//class CustomersCollection : ICustomersCollection, IOrderedCustomersCollection
//{
//    private List<string> names = new List<string>();

//    public void Add(string name)
//    {
//        names.Add(name);
//    }

//    public List<string> GetNames() => names;

//    List<string> IOrderedCustomersCollection.GetNames() => names.OrderBy(x => x).ToList();
//}