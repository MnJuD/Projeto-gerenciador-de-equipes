using System;
 class equipes{
     static void Main(string[] args){
         string e1,e2,e3,e4,equipeVence1,equipeVence2;
         int jogo1,jogo2,final;

         // Introdução do programa.
         
         Console.Write("=================================================\n");
         Console.Write("=================================================\n");
         Console.Write("== BEM VINDO AO GERENCIADOR DE CAMPEONATOS !!!===\n");
         Console.Write("=================================================\n");
         Console.Write("=================================================\n\n");

         Console.Write("O GERENCIADOR DE CAMPEONATOS É MUITO SIMPLES DE SE USAR:\n\n");
         Console.Write("  O campeonato consiste em um mata-mata onde 4 equipes disputarão para ver quem é o melhor ,\n");
         Console.Write("para iniciar basta inserir os nomes de cada equipe.\n\n");
         
        // Início 
        
         Console.WriteLine("Digite o nome da primeira equipe: ");
         e1 = Console.ReadLine();
         
         Console.Write("\nDigite o nome da segunda equipe:\n");
         e2=Console.ReadLine();
         
         Console.Write("\nDigite o nome da terceira equipe:\n");
         e3=Console.ReadLine();
         
         Console.Write("\nDigite o nome da quarta equipe:\n");
         e4=Console.ReadLine();

         Console.Write("\nO primeiro jogo será da equipe " + e1 + " contra a equipe " + e2 + " !!!\n\n");
        
         Console.Write("Caso a equipe " + e1 + " VENCEU digite 1, caso a equipe " + e2 + " VENCEU digite 2 !!!\n");
         jogo1=int.Parse(Console.ReadLine());

         if(jogo1 == 1){
             Console.Write("\n\n========================================================\n");
             Console.Write("== PARABÉNS " + e1 + " VOCÊS PASSARAM PARA A FINAL !!!===\n");
             Console.Write("========================================================\n\n");
         }else{
             Console.Write("\n\n========================================================\n");
             Console.Write("== PARABÉNS " + e2 + " VOCÊS PASSARAM PARA A FINAL !!!===\n");
             Console.Write("========================================================\n\n");
         }

         if(jogo1 == 1){
             equipeVence1 = e1;
         }else{
             equipeVence1 = e2 ;
         }

         Console.Write("O segundo jogo será da equipe " + e3 + " contra a equipe " + e4 + " !!!\n\n");
        
         Console.Write("Caso a equipe " + e3 + " VENCEU digite 1, caso a equipe " + e4 + " VENCEU digite 2 !!!\n");
         jogo2=int.Parse(Console.ReadLine()); 
         
         if(jogo2 == 1){
             Console.Write("\n\n========================================================\n");
             Console.Write("== PARABÉNS " + e3 + " VOCÊS PASSARAM PARA A FINAL !!!===\n");
             Console.Write("========================================================\n\n");
         }else{
             Console.Write("\n\n========================================================\n");
             Console.Write("== PARABÉNS " + e4 + " VOCÊS PASSARAM PARA A FINAL !!!===\n");
             Console.Write("========================================================\n\n");
         }

         if(jogo2 == 1){
             equipeVence2 = e3;
         }else{
             equipeVence2 = e4 ;
         }

         Console.Write("A FINAL será da equipe " + equipeVence1 + " contra a equipe " + equipeVence2 + " !!!\n\n");
        
         Console.Write("Caso a equipe " + equipeVence1 + " VENCEU digite 1, caso a equipe " + equipeVence2 + " VENCEU digite 2 !!!\n");
         final=int.Parse(Console.ReadLine());

         if(final == 1){
            Console.Write("\n\n========================================================\n");
            Console.Write("========================================================\n");
             Console.Write(" PARABÉNS " + equipeVence1 + " VOCÊS VENCERAM O CAMPEONATO !!!\n");
             Console.Write("========================================================\n");
             Console.Write("========================================================");
         }else{
             Console.Write("\n\n========================================================\n");
             Console.Write("========================================================\n");
             Console.Write(" PARABÉNS " + equipeVence2 + " VOCÊS VENCERAM O CAMPEONATO !!!\n");
             Console.Write("========================================================\n");
             Console.Write("========================================================");
         }
     }
}