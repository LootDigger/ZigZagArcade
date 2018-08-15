using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventController {


    static Dictionary<Consts.Events.events, Action> Events = new Dictionary<Consts.Events.events, Action>();
    static event Action myFirstEvent;


    public static void Subscribe(Consts.Events.events gameEvent, Action method)
    {
        if (Events.ContainsKey(gameEvent) && Events.ContainsValue(method))
            return;            

        if (gameEvent == Consts.Events.events.myfirstEvent)
        {
            myFirstEvent += method;
            Events.Add(gameEvent, method);
        }
    }


    public static void InvokeEvent(Consts.Events.events eventParametr)
    {
        if (Events.ContainsKey(Consts.Events.events.myfirstEvent))
        {

            if (eventParametr == Consts.Events.events.myfirstEvent)
            {
                myFirstEvent();
            }
        }
    }

    public void testMethod()
    {
        Debug.Log("Event Handler Method");
    }

    public void OthertestMethod()
    {
         EventController.Subscribe(Consts.Events.events.myfirstEvent, testMethod);
       
    }
}
