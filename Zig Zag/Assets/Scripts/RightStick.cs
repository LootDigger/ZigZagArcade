using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightStick : MonoBehaviour {

    private bool isMoving = false;


    void Start()
    {
        EventController.Subscribe(Consts.Events.events.startRightStick, StartMovement);
    }


    void StartMovement()
    {
        Debug.Log("Start right stick movement");
        isMoving = true;
    }


    void Move(Vector3 startPos, Vector3 endPos)
    {
        if (transform.position.y <= endPos.y)
        {
            Vector3 position = transform.position;
            position.y += Consts.Values.stickSpeed * Time.deltaTime;
            transform.position = position;
        }

    }

    void Update()
    {
        if (isMoving)
        {
            Move(Consts.Coordinates.rightStickStartPosition, Consts.Coordinates.rightStickEndPosition);

            if (Input.GetMouseButton(0))
            {
                isMoving = false;
            }
        }

    }
}
