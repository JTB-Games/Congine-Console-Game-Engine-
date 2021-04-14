# Congine-Console-Game-Framework
A console game Framework made using c# and .net console.
Comes with a pre-programmed in game (flappy bird without obstacles).

I think its mostly done I just want to add a falling sand cellular automata rotation and scaling and built in collision detection.
You can use this for anything you would like. It only works on windows i think.

The framework is a bit confusing so I will do my best to explain it.

A Object is... well an object it can hold components such as polygons.

A polygon takes a list of point (Vertex) and draws a shape there it must be attached to an object. in order to display the polygon you must create a Screen.

screen contains functions such as .blit() and .simpleBlit() blit takes in a polygon which will then be displayed on the screen. simpleBlit takes text and a position and will then write the text at said position.

Vertex is a point used by polygons it takes a color a position and a Ascii symbol.

in order to get the screen to render smoothly you must create a while(true) loop and in said loop you must put eCon.optimizeScreen() it will optimize the screen so that there will be no flickering. then you can get input and any other things. When you are ready to render the screen you must type console.clear() screen.blit / screen.simpleBlit/console.writeline. all input must be collected in a single if else statement other wise it will not get the input.

To get input you type Inputget.Getkey(consolekey) you can also use inputget.horizontal to get A/D key input it returns a float.

In order to use the audio class you must create a new sound which then you must give the new sound an new audiopoint[] 

Audiopoint takes a pitch and a duration if the pitch is below 37 its suppost to just wait the duration of the audiopoint but that wont work for some reason.

Once you have set up the sound you can play it with audio.playsound(the sound) this will play asynchronous with the game.


 
