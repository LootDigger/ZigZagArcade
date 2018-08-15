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



    public void FlyToRight()
    {
        float minYPos = transform.position.y;
        float yPos = Random.Range(minYPos, Consts.Coordinates.maxYPos);
        Vector3 flyEndPosition = new Vector3(Consts.Coordinates.maxXPosition, yPos, transform.position.z);
        this.gameObject.transform.DOMove(flyEndPosition, 2f, false);//.SetEase(Ease.InOutExpo, 1f);
    }


    public void FlyToLeft()
    {
        float minYPos = transform.position.y;
        float yPos = Random.Range(minYPos, Consts.Coordinates.maxYPos);
        Vector3 flyEndPosition = new Vector3(Consts.Coordinates.minXPosition, yPos, transform.position.z);
        this.gameObject.transform.DOMove(flyEndPosition, 2f, false);//.SetEase(Ease.InOutExpo, 1f);

    }
}
