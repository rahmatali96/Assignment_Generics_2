using System;

namespace Assignment_Generics_Second
{
    public class Program
    {
        public static string searchValue(int value,Dictionary<string,int> Diction){
       
        foreach(KeyValuePair<string,int> item in Diction){
            if(item.Value == value){
                return item.Key;
            }
        }
        return "Item not Find" ;
        }
        public static void Main(string[] args)
        {
            var Diction = new Dictionary<string,int>();
            Diction["Atal Bihari Vajpayee"] = 1998;
            Diction["Narendra Modi"] = 2014;
            Diction["Manmohan Singh"] = 2004;
            //PM in 2004
            Console.WriteLine("Prime minister of {0} was {1}",2004,searchValue(2004,Diction));
            //Adding current PM
            Diction["Narendra Modi"] = 2019;
            Console.WriteLine("Current Prime Minister added");
            //list before Sorting
            Console.WriteLine("Before Sorting");
            foreach (var KeyValP in Diction)
            {
                Console.WriteLine("{0}, {1}", KeyValP.Key, KeyValP.Value);
            }
            //List after sorting
            Console.WriteLine("After Sorting");
            Diction = Diction.OrderBy(sort=>sort.Value).ToDictionary(sort=>sort.Key, sort=>sort.Value);
            foreach (var KeyValP in Diction)
            {
             Console.WriteLine("{0}, {1}", KeyValP.Key, KeyValP.Value);
            }
        }
    }
}
