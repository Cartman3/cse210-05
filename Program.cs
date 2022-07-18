using cse210_05.Game.Casting;
using cse210_05.Game.Directing;
using cse210_05.Game.Scripting;
using cse210_05.Game.Services;


namespace cse210_05
{
    // The program's entry point.
    class Program
    {
        // Starts the program.
        static void Main(string[] args)
        {
            // create the cast using polymorphism.
            Cast cast = new Cast();
            cast.AddActor("cycletwo", new CycleTwo());
            cast.AddActor("cycleone", new CycleOne());
            cast.AddActor("onescore", new OneScore());
            cast.AddActor("twoscore", new TwoScore());
            

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
            
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlCycleOneAction(keyboardService));
            script.AddAction("input", new ControlCycleTwoAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}