using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	
	void Start()
    {
        EventController.Subscribe(Consts.Events.events.myfirstEvent, Method);
        
    }
    

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            EventController.InvokeEvent(Consts.Events.events.myfirstEvent);


    }

    void Method () {
        Debug.Log("Method");
	}
}
