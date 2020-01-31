using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista1 = CreaListGen("1", "2", "3");
            var lista2 = CreaListGen(1, 2, 3);

        }

        private static List<T> CreaListGen<T>(params T[] lista)
        {

            List<T> listaGen = new List<T>();

            foreach (var ls in lista)
            {
                listaGen.Add(ls);
            }
            return listaGen;
        }   
    }
}



// using System;
// using System.Collections.Generic;

// namespace Generics
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Console.WriteLine("Hello World!");
//             var listaString = CreaListString("1", "2", "3");
//             var listaInt = CreaListInt(1, 2, 3);

//         }

//         private static List<string> CreaListString(params string[] lista)
//         {

//             List<string> listaString = new List<string>();

//             foreach (var ls in lista)
//             {
//                 listaString.Add(ls);

//             }
//             return listaString;

//         }

//         private static List<int> CreaListInt(params int[] lista)
//         {

//             List<int> listaInt = new List<int>();

//             foreach (var ls in lista)
//             {
//                 listaInt.Add(ls);

//             }
//             return listaInt;

//         }
//     }
// }
