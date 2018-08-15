using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioController : MonoBehaviour {


	void Start ()
    {
        EventController.Subscribe(Consts.Events.events.startGame, StartGame);

	}
	


    void StartGame()
    {
        EventController.InvokeEvent(Consts.Events.events.flyToBoard);
    }


	void Update () {
		
	}
}
