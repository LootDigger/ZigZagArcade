using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsActivityController : MonoBehaviour {
    

    public void StartGame()
    {
        Debug.Log("Invoke Start Game");
        EventController.InvokeEvent(Consts.Events.events.startGame);
    }


    public void Replay()
    {
        EventController.InvokeEvent(Consts.Events.events.replay);
    }
}
