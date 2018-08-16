using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventController {


    static Dictionary<Consts.Events.events, Action> Events = new Dictionary<Consts.Events.events, Action>();
    static event Action flyToBoard;
    static event Action startGame;
    static event Action startLeftStick;
    static event Action startRightStick;


    public static void Subscribe(Consts.Events.events gameEvent, Action method)
    {
        if (Events.ContainsKey(gameEvent) && Events.ContainsValue(method))
            return;            

        

        if(gameEvent == Consts.Events.events.flyToBoard)
        {
            flyToBoard += method;
            Events.Add(gameEvent, method);
        }

        if(gameEvent == Consts.Events.events.startGame)
        {
            startGame += method;
            Events.Add(gameEvent, method);
        }

        if (gameEvent == Consts.Events.events.startLeftStick)
        {
            startLeftStick += method;
            Events.Add(gameEvent, method);
        }

        if (gameEvent == Consts.Events.events.startRightStick)
        {
            startRightStick += method;
            Events.Add(gameEvent, method);
        }

    }


    public static void InvokeEvent(Consts.Events.events eventParametr)
    {
        

            if (eventParametr == Consts.Events.events.flyToBoard)
            {
                flyToBoard();
            }

            if (eventParametr == Consts.Events.events.startGame)
            {
                startGame();
            }

            if (eventParametr == Consts.Events.events.startLeftStick)
            {
                startLeftStick();
            }

            if (eventParametr == Consts.Events.events.startRightStick)
            {
                startRightStick();
            }


        
    }
    
   
}
