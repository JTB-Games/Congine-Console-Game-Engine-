using System;
using System.Threading;
using System.Threading.Tasks;

namespace Congine
{
    
    class vector2{
        
   public float x { get; private set; }
   public float y { get; private set; }

   public float originalX{ get; private set; }
   public float originalY{ get; private set; }

        public vector2(float X, float Y){
            x = (Console.WindowWidth / 2) - X;
            y = (Console.WindowHeight / 2) - Y;
            originalX = X;
            originalY = Y;
        }
        

        public static vector2 zero(){
            return new vector2(0,0);
        }
        public static vector2 right(){
            return new vector2(1,0);
        }
        public static vector2 left(){
            return new vector2(-1,0);
        }
        public static vector2 up(){
            return new vector2(0,1);
        }
        public static vector2 down(){
            return new vector2(0,-1);
        }
    }
    static class eCon{
        
        public static void AsciiChart(){
            int e = char.MinValue;
            
            for(char i = char.MinValue; i < char.MaxValue; i++){
                Console.Write(e + " " + i + " ");
                e++;
                eCon.Wait(1);
            }
            
        }
        public static void OptimizeScreen(){
            Console.SetWindowSize(200, 40);
            Console.SetBufferSize(200, 40);
            Console.CursorVisible = false;
        }
        public static void setCursorPosition(vector2 position){
            Console.SetCursorPosition((int)Math.Round((decimal)position.x, 0), (int)Math.Round((decimal)position.y, 0));
        }
        public static void Wait(int miliseconds){
            Thread.Sleep(miliseconds);
        }
        
        
    }

class screen{
   

    public void qClear(){
            Task.Run(() => renderClear());
        }

    static Task renderClear()
        {
     

        Console.Clear();

        return Task.FromResult(0); 
        }   

        public void blit(polygon poly){
            foreach (Vertex vert in poly.Points)
            {
                vector2 position = new vector2(vert.Position.x, vert.Position.y);
                vector2 FinalPosition = new vector2(position.x + poly.body.Position.originalX, position.y + poly.body.Position.originalY);
                eCon.setCursorPosition(FinalPosition);
                Console.ForegroundColor = vert.Color;
                
                Console.Write(vert.Charactor);
                
            }
        }
        public void Simpleblit(vector2 position, string SimpleText){
            eCon.setCursorPosition(position);
        Console.Write(SimpleText);
        }

    

}
    class Object{
        public vector2 Position;
        public vector2 Scale;

        public float Rotation;
        public Object(vector2 position, vector2 scale, float rotation){
Position = position;
Scale = scale;
Rotation = rotation;
        }
    }
    class polygon{
        public Vertex[] Points;
        public Object body;
        public polygon(Object Body, Vertex[] mesh){
                Points = mesh;
                body = Body;

        }
    }
    
   static class Audio{
        public static void playSound(Sound sound){
                foreach(AudioPoint point in sound.AudioPoints){
                    if(point.pitch > 37){
                    new Thread(() => Console.Beep(point.pitch, point.duration)).Start();
                    }else{
                        new Thread(() => Thread.Sleep(point.duration)).Start();
                    }
                }
        }
    }
    class Sound{
       public AudioPoint[] AudioPoints;
       public Sound(AudioPoint[] points){
           AudioPoints = points;
       }
    }
    class AudioPoint{
       public  int pitch;
       public  int duration;
        public AudioPoint(int Pitch, int Duration){
        pitch = Pitch;
        duration = Duration;
        }
    }

    class Vertex{
        public vector2 Position;
        public ConsoleColor Color;

        public char Charactor;
        public Vertex(vector2 position, ConsoleColor color, char charactor){
            Color = color;
            Position = position;
            Charactor = charactor;
        }
    }
 
   static class inputGet{
        public static bool GetKey(ConsoleKey Key){
                if(Console.KeyAvailable){
                var input = Console.ReadKey(true);

                if(input.Key == Key){
                return true;
                }else{
                return false;
             }
            }else{
                return false;
            }

        
        }

        public static int Horizontal(){
            if(Console.KeyAvailable){
               ConsoleKeyInfo input = Console.ReadKey();

                if(input.Key == ConsoleKey.A){
                return -1;
                }else if(input.Key == ConsoleKey.D){
                return 1;
             }else{
                 return 0;
             }
            }else{
                return 0;
            }
        }

         public static int Vertical(){
            if(Console.KeyAvailable){
                ConsoleKeyInfo input = Console.ReadKey();

                if(input.Key == ConsoleKey.S){
                return -1;
                }else if(input.Key == ConsoleKey.W){
                return 1;
             }else{
                 return 0;
             }
            }else{
                return 0;
            }
        }
    }
}