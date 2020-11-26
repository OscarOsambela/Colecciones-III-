using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Queue<int> numeros = new Queue<int>();
    //rellenando o agregando elementos a la cola
    foreach(int numero in new int[]{1,2,3,4,5}){
      numeros.Enqueue(numero);
    }
    
    //recorriendo la cola 
    Console.WriteLine("recorriendo el queue");
    foreach(int numero in numeros){
      Console.WriteLine(numero);
    }
    //eliminando elementos de la cola
    Console.WriteLine("Eliminando elementos");
    numeros.Dequeue();
    foreach(int numero in numeros){
      Console.WriteLine(numero);
    }
  }
}