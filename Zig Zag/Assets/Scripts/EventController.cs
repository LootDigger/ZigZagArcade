using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventController {


    static event Action jump;
    static event Action startGame;
    static event Action startLeftStick;
    static event Action startRightStick;
    static event Action Lose;
    static event Action letDown;


    public static void Subscribe(Consts.Events.events gameEvent, Action method)
    {
        
        if(gameEvent == Consts.Events.events.jump)
        {
            jump += method;
        }

        if(gameEvent == Consts.Events.events.startGame)
        {
            startGame += method;
        }

        if (gameEvent == Consts.Events.events.startLeftStick)
        {
            startLeftStick += method;
        }

        if (gameEvent == Consts.Events.events.startRightStick)
        {
            startRightStick += method;
        }

        if(gameEvent == Consts.Events.events.lose)
        {
            Lose += method;
        }


        if (gameEvent == Consts.Events.events.letDown)
        {
            letDown += method;
        }

    }

    public static void Unsubscribe(Consts.Events.events gameEvent, Action method)
    {

        if (gameEvent == Consts.Events.events.jump)
        {
            jump -= method;
        }

        if (gameEvent == Consts.Events.events.startGame)
        {
            startGame -= method;
        }

        if (gameEvent == Consts.Events.events.startLeftStick)
        {
            startLeftStick -= method;
        }

        if (gameEvent == Consts.Events.events.startRightStick)
        {
            startRightStick -= method;
        }

        if (gameEvent == Consts.Events.events.lose)
        {
            Lose -= method;
        }


        if (gameEvent == Consts.Events.events.letDown)
        {
            letDown -= method;
        }

    }

    public static void InvokeEvent(Consts.Events.events eventParametr)
    {
        

            if (eventParametr == Consts.Events.events.jump)
            {
                jump();
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

            if(eventParametr == Consts.Events.events.lose)
            {
                Lose();
            }

            if (eventParametr == Consts.Events.events.letDown)
            {
                letDown();
            }

    }
    
   
}
