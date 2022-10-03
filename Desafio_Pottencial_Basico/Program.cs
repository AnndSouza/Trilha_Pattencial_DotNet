// using System;

// class DIO {
        
// static void Main(string[] args){

//         int n = int.Parse(Console.ReadLine());
//         int p = 1, s = 0;
//         while (n > 0){
//              int l = n % 10;
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//              p = p * l; 
//              s = s + l   ;
//              n = n / 10    ;
//            }

//            Console.WriteLine(p-s);
//         }
//     }

// using System.IO;
// using System.Linq;
// using System;

// class Program {
//   static void Main(string[] args) {
//     int qt = int.Parse(Console.ReadLine());
    
    
//     for (int i = 0; i < qt; ++i) {

//       string [] v = Console.ReadLine().Split(" ");

//       string a = v[0];
//       string b = v[1];

//       if (b.Length > a.Length)
//         Console.WriteLine("nao encaixa");
//       else if (a.EndsWith(b))
//         Console.WriteLine("encaixa");
//       else
//         Console.WriteLine("nao encaixa");
//     }
//   }
// }

// using System;
 
// class Solution {
//     public static void Main(string[] args) {
//         int n = int.Parse(Console.ReadLine());
//         int count = 0;
 
//         for (int i = 1; i <= n; i++) {
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//             if (n % i ==   0  ) {
//                 count++;
//             }
//             if (count >  i   ) {
//                 Console.WriteLine(false);
//             }
//         }
//          Console.WriteLine(count == 3);
//     }
// }