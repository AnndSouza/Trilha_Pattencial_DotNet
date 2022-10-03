// using System;
// using System.Text.RegularExpressions;

// public class Program
// {
//     public static void Main(String[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
        
//         int[] num = new int[n];
    
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (int i = 0; i < n; i++)
//         {
//             num[i] = int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine(MajorityElement(num));
        
//     }
//     public static int MajorityElement(int[] nums)
//     {
//         int major = nums[0];
//         int count = 1;
//         for (int i = 0; i < count; i++)
//         {
//             if ( count == major/2)
//             {
//                 major = nums[i];
//                 count += 1;
//             }
//             else
//             {
//                 if (major == nums[i])
//                 {
//                     count++;
//                 }
//                 else
//                 {
//                     count--;
//                 }
//             }
//         }
//         return major;
//     }
// }

// using System;  


// class minhaClasse { 

//   static void Main(string[] args) {

    
//     double salario = 0.00; 
//     double reajuste = 0.00; 
//     double novoSalario = 0.00; 
//     double percentual = 0.00; 


    
//     salario = Convert.ToDouble(Console.ReadLine()); 

// //TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    
        
    
//         if (salario < 0.00) 
//         {
//             return;
//         }

//         else if (salario <= 400.00)
//         {
//             percentual = 0.15;
//             reajuste = salario * percentual;
//             novoSalario = salario + reajuste;
//         }

//         else if (salario <= 800.00) 
//         {
//             percentual = 0.12;
//             reajuste = salario * percentual;
//             novoSalario = salario + reajuste;
//         }

//         else if (salario <= 1200.00)
//         {
//             percentual = 0.10;
//             reajuste = salario * percentual;
//             novoSalario = salario + reajuste;
//         }

//         else if (salario <= 2000.00)
//         {
//             percentual = 0.07;
//             reajuste = salario * percentual;
//             novoSalario = salario + reajuste;
//         }

//         else 
//         {
//             percentual = 0.04;
//             reajuste = salario * percentual;
//             novoSalario = salario + reajuste;
//         }
    
//         Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
//         Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
//         Console.WriteLine("Em percentual: {0} %", percentual * 100);
//     }
// }


// using System;

// class Desafio {
//   public static void Main() {
//     int quantidadeEntradas = 3;
      
//     while (quantidadeEntradas > 0) {
//       var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
//       if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
//         string[] tartarugas = Console.ReadLine().Split(" ");
//         var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (int i = 1; i < numeroQuantidade; i++) {
//           var tartaruga = Int32.Parse(tartarugas[i]);
            
//           if (tartaruga > maiorVelocidade) {
//             maiorVelocidade = tartaruga;
//           }
//         }

//         if(maiorVelocidade < 10) {
//           Console.WriteLine(1);
//         } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
//           Console.WriteLine(2);
//         } else if ( maiorVelocidade >= 20) {
//           Console.WriteLine(3);
//         }
//         quantidadeEntradas--;
//       } else {
//         Console.WriteLine("Insira um número entre 1 e 500");
//       }
//     }
//   }
// }