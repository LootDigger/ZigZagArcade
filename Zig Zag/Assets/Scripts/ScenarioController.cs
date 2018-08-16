using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScenarioController : MonoBehaviour {

    [SerializeField]
    private GameObject leftStick;

    [SerializeField]
    private GameObject rightStick;

	void Start ()
    {
        EventController.Subscribe(Consts.Events.events.startGame, StartGame);
        
    }
	


    void StartGame()
    {
        Debug.Log("Start Game");
        EventController.InvokeEvent(Consts.Events.events.flyToBoard);
    }

    void StartLeftStick()
    {
        

    }

    void StartRightStick()
    {


    }

    void MoveStick(GameObject stick)
    {

    }


    void Update ()
    {
		
	}
}
