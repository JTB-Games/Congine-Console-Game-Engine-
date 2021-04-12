using System;
using System.Threading.Tasks;
using System.Threading;
namespace Congine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Congine Bird";
            
            
            eCon.OptimizeScreen();
            screen Screen = new screen();
            
           float gravity = 0;
            Console.ReadKey();
            vector2 test2 = new vector2(0, 0);
            Object obj = new Object(test2,test2,0);
            Console.BackgroundColor = ConsoleColor.White;
            polygon poly = new polygon(obj, new Vertex[]{
                /*
                new Vertex(new vector2(-1,1), ConsoleColor.Yellow, (char)9632),
                new Vertex(new vector2(-1,0), ConsoleColor.Yellow, (char)9632),
                new Vertex(new vector2(-1,-1), ConsoleColor.Yellow, (char)9632),
                new Vertex(new vector2(1,1), ConsoleColor.Yellow, (char)9632),
                new Vertex(new vector2(1,0), ConsoleColor.Yellow, (char)9632),
                new Vertex(new vector2(1,-1), ConsoleColor.Yellow, (char)9632),
                new Vertex(new vector2(0,1), ConsoleColor.Yellow, (char)9632),
                new Vertex(new vector2(0,-1), ConsoleColor.Yellow, (char)9632),
                */
                new Vertex(new vector2(-1,1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(-1,0), ConsoleColor.Black, (char)9608),
                new Vertex(new vector2(-1,-1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(1,1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(1,0), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(1,-1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(0,1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(0,-1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(2,1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(2,0), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(2,-1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(-2,1), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(-2,0), ConsoleColor.Yellow, (char)9608),
                new Vertex(new vector2(-2,-1), ConsoleColor.Black, (char)9608),
                new Vertex(new vector2(0,0), ConsoleColor.Yellow, (char)9608),
               
                new Vertex(new vector2(3,-1), ConsoleColor.Red, (char)9619),
            });

            Sound Jump = new Sound(new AudioPoint[]{
                    new AudioPoint(500, 100),
                    
                    
            });
            while(true){


                if(inputGet.GetKey(ConsoleKey.Spacebar)){
                    gravity = -1;
                   Audio.playSound(Jump);
                }

                gravity += 0.05f;
           eCon.OptimizeScreen();
           
           
               obj.Position = new vector2(obj.Position.originalX - 0, obj.Position.originalY - gravity);
           
               
                   
               
           
           
                
                
                Console.Clear();
                Screen.blit(poly);
            eCon.Wait(1);
            
            
            }
            
            
            

        }
        
        
    }
}
