using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Programas
{
    class Program
    {
		
        static void Main(string[] args){

			int[] prueba = new int[1000000000];
			int contador = 0;
			
			Stopwatch crono = new Stopwatch();
			
			crono.Start();
			
			for(int i = 999999999; i >= 0; i--){
				
				if(i == 0){
					
					prueba[i] = 15;
					crono.Stop();
					Console.WriteLine("Tiempo: " + crono.Elapsed);
					
				}
				
				contador+=1;
				
			}
			
			Console.WriteLine("Cantidad de iteraciones: " + contador);
			
			contador = 0;
			crono.Restart();
			crono.Start();
			
			for(int a = 0; a < prueba.Length; a++){
				
				if(a == 999999999){
					
					prueba[a] = 15;
					crono.Stop();
					Console.WriteLine("Tiempo: " + crono.Elapsed);
					
				}
				
				contador+=1;
				
			}
			
			Console.WriteLine("Cantidad de iteraciones: " + contador);

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();

        }

    }
}
