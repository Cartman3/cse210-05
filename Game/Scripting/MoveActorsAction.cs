using System.Collections.Generic;
using cse210_05.Game.Casting;


namespace cse210_05.Game.Scripting
{
    // TODO: Implement the MoveActorsAction class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Action class.

    // An update action that moves all the actors.
    // The responsibility of MoveActorsAction is to move all the actors.
    public class MoveActorsAction : Action
    {

    // Constructs a new instance of MoveActorsAction.
        public MoveActorsAction(){

        }

    // 3) Override the Execute(Cast cast, Script script) method. Use the following 
    //    method comment. You custom implementation should do the following:
    //    a) get all the actors from the cast
    //    b) loop through all the actors
    //    c) call the MoveNext() method on each actor.
        public void Execute(Cast cast, Script script){
            List<Actor> actors = cast.GetAllActors();
            foreach(Actor actor in actors){
                actor.MoveNext();
            }
        }
    }
}