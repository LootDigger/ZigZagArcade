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

    //public void FlyToRight()
    //{

    //    float minYPos = transform.position.y;
    //    float yPos = Random.Range(minYPos, Consts.Coordinates.maxYPos);
    //    Vector3 flyEndPosition = new Vector3(Consts.Coordinates.maxXPosition, yPos, transform.position.z);
        
    //    Vector3 middlePos = FindMiddlePoint(transform.position, flyEndPosition);
        
    //    Sequence seq = DOTween.Sequence();
    //    seq.Append(this.gameObject.transform.DOMove((middlePos), 1f, false));
    //    seq.OnComplete(startRightStick);
    //    Sequence seq2 = DOTween.Sequence();
    //    seq2.AppendInterval(3f);
    //    seq2.Append(this.gameObject.transform.DOMove((flyEndPosition), 0.5f, false));
        
    //}



    //Vector3 FindMiddlePoint(Vector2 start, Vector2 end)
    //{

    //    Vector3 middlePoint;

    //    middlePoint = (end - start);
    //    Debug.Log("start = " + start);
    //    Debug.Log("end = " + end);
    //    Debug.Log("Разница векторов = " + middlePoint);

    //    middlePoint /= 1.2f;
    //    middlePoint.x = end.x - middlePoint.x;
    //    middlePoint.y = end.y - middlePoint.y;

    //    Debug.Log(" Средняя точка" + middlePoint);
    //    middlePoint.z = Consts.Coordinates.zCoord;
    //    return middlePoint;

    //}

    //public void startLeftStick()
    //{
    //    EventController.InvokeEvent(Consts.Events.events.startLeftStick);
    //}


    //public void startRightStick()
    //{
    //    EventController.InvokeEvent(Consts.Events.events.startRightStick);
    //}

    //public void FlyToLeft()
    //{
    //    float minYPos = transform.position.y;
    //    float yPos = Random.Range(minYPos, Consts.Coordinates.maxYPos);

    //    Vector3 flyEndPosition = new Vector3(Consts.Coordinates.minXPosition, yPos, transform.position.z);
    //    Vector3 middlePos = FindMiddlePoint(transform.position, flyEndPosition);


    //    Sequence seq = DOTween.Sequence();
    //    seq.Append(this.gameObject.transform.DOMove((middlePos), 1f, false));
    //    seq.OnComplete(startLeftStick);
    //    Sequence seq2 = DOTween.Sequence();
    //    seq2.AppendInterval(3f);
    //    seq2.Append(this.gameObject.transform.DOMove((flyEndPosition), 0.5f, false));

    //}
}
