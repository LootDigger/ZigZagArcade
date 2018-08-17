using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Ball : MonoBehaviour {

    private bool isTurnedLeft = true;
	void Start ()
    {
        transform.position = Consts.Coordinates.ballStartPosition;
        EventController.Subscribe(Consts.Events.events.flyToBoard, FlyToBoard);            
    }
	
	

    void FlyToBoard()
    {
        Debug.Log("Fly!");
        
        if (!isTurnedLeft)
        {
            Debug.Log("Right");
            FlyToRight();
        }


        if (isTurnedLeft)
        {
            Debug.Log("Left");
            FlyToLeft();
        }
       
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");

        if(other.tag == "LeftStick" || other.tag == "RightStick")
        {
            isTurnedLeft = !isTurnedLeft;
            Debug.Log("Touch Stick");
            EventController.InvokeEvent(Consts.Events.events.flyToBoard);
        }

    }

    public void FlyToRight()
    {
        EventController.InvokeEvent(Consts.Events.events.startRightStick);

        float minYPos = transform.position.y;
        float yPos = Random.Range(minYPos, Consts.Coordinates.maxYPos);
        Vector3 flyEndPosition = new Vector3(Consts.Coordinates.maxXPosition, yPos, transform.position.z);


        Vector3 middlePos = flyEndPosition;

        middlePos.x = flyEndPosition.x - transform.position.x;
        middlePos.y = flyEndPosition.y - transform.position.y;
        Debug.Log(middlePos);

        Sequence seq = DOTween.Sequence();
        seq.Append(this.gameObject.transform.DOMove((flyEndPosition), 2f, false));
       // this.gameObject.transform.DOMove(flyEndPosition, 2f, false);//.SetEase(Ease.InOutExpo, 1f);
        
    }



    Vector3 FindMiddlePoint(Vector2 start, Vector2 end)
    {

        Vector3 middlePoint;

        middlePoint = (end - start);
        Debug.Log("start = " + start);
        Debug.Log("end = " + end);
        Debug.Log("Разница векторов = " + middlePoint);

        middlePoint /= 1.2f;
        middlePoint.x = end.x - middlePoint.x;
        middlePoint.y = end.y - middlePoint.y;

        Debug.Log(" Средняя точка" + middlePoint);
        middlePoint.z = Consts.Coordinates.zCoord;
        return middlePoint;

    }

    public void FlyToLeft()
    {
        EventController.InvokeEvent(Consts.Events.events.startLeftStick);
        float minYPos = transform.position.y;
        float yPos = Random.Range(minYPos, Consts.Coordinates.maxYPos);

        Vector3 flyEndPosition = new Vector3(Consts.Coordinates.minXPosition, yPos, transform.position.z);
        Vector3 middlePos = FindMiddlePoint(transform.position, flyEndPosition);


        Debug.Log("Middle point еще раз" + middlePos);
        Sequence seq = DOTween.Sequence();
        seq.Append(this.gameObject.transform.DOMove((middlePos), 1f, false));
        seq.Append(this.gameObject.transform.DOMove((flyEndPosition), 0.5f, false));        
    }
}
