using System.Collections.Generic;
using cse210_05.Game.Casting;
using cse210_05.Game.Services;


namespace cse210_05.Game.Scripting
{
    // An output action that draws all the actors.
    // The responsibility of DrawActorsAction is to draw each of the actors.
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        // Constructs a new instance of ControlActorsAction using the given KeyboardService.
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        // <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            CycleOne cycleone = (CycleOne)cast.GetFirstActor("cycleone");
            List<Actor> segments1 = cycleone.GetSegments();
            CycleTwo cycletwo = (CycleTwo)cast.GetFirstActor("cycletwo");
            List<Actor> segments2 = cycletwo.GetSegments();
            Actor onescore = cast.GetFirstActor("onescore");
            Actor twoscore = cast.GetFirstActor("twoscore");
            twoscore.SetPosition(new Point(Constants.MAX_X -100, 0));
            List<Actor> messages = cast.GetActors("messages");
            
            videoService.ClearBuffer();
            videoService.DrawActors(segments1);
            videoService.DrawActors(segments2);
            videoService.DrawActor(onescore);
            videoService.DrawActor(twoscore);
            videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }
}