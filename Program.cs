using System;
using cards_Yu_Gi_Oh.src.Entities;


namespace cards_Yu_Gi_Oh{

class Program{
static void Main(string[] args){

    Console.WriteLine("Olá jogador! ");
    Console.WriteLine("A seguir será mostrado as cartas que você possui: ");
    agua Dragao = new agua("Dragão Leviatã", 3, "Água ");
    trevas Broca_Negra = new trevas("Broca Negra", 4, "Trevas ");
    Console.WriteLine(Dragao);
    Console.WriteLine(Dragao.Attack());
    Console.WriteLine(Broca_Negra);
    Console.WriteLine(Broca_Negra.Attack());

    

    
    








    }



}
    
}
