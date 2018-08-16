using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Stick : MonoBehaviour
{
    private bool isMovingStarted = false;
    private Vector2 movementStartPos;
    private Vector2 movementEndPos;
    private float t = 0;


    public void Start()
    {
    }
    

    public void startMoving( Vector2 startPos, Vector2 endPos)
    {
        Debug.Log("Start moving");
        movementStartPos = startPos;
        movementEndPos = endPos;

        isMovingStarted = true;
       // transform.DOMove(endPos, 3f);
    }


    void Update()
    {

        Vector2.Lerp(transform.position, Consts.Coordinates.leftStickEndPosition, Time.deltaTime);
        if(isMovingStarted)
        {
            t += Time.deltaTime;
            Debug.Log("t = " + t);
           // Vector2.Lerp(movementStartPos, movementEndPos,t);
           
        }


    }


}
