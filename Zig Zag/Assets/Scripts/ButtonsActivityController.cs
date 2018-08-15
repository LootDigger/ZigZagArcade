using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsActivityController : MonoBehaviour {
    

    public void StartGame()
    {
        EventController.InvokeEvent(Consts.Events.events.startGame);
    }
}
