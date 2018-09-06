using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Ball : MonoBehaviour {

    private bool isTurnedLeft = true;
	void OnEnable ()
    {
      //  transform.position = Consts.Coordinates.ballStartPosition;
        EventController.Subscribe(Consts.Events.events.jump, Jump);
        EventController.Subscribe(Consts.Events.events.lose, Death);
    }
	
	

    void Jump()
    {
       Rigidbody2D rb = GetComponent<Rigidbody2D>();
       float val = Random.Range(-20f, 20f);
       rb.AddForce(new Vector2(val, 0), ForceMode2D.Impulse);
       
    }

    public void Death()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "LeftStick" || other.tag == "RightStick")
        {
            isTurnedLeft = !isTurnedLeft;
            EventController.InvokeEvent(Consts.Events.events.jump);
        }

        if (other.tag == "DeadZone" )
        {
            transform.position = new Vector3(0, 5, -606);
            EventController.Unsubscribe(Consts.Events.events.jump, Jump);
            Destroy(this.gameObject);
            EventController.InvokeEvent(Consts.Events.events.lose);

        }



    }

    
}
