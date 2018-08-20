using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LeftStick : MonoBehaviour {

    private bool isMoving = false;
    float AccelerometerUpdateInterval = 1f / 600f;
    float LowPassKernelWidthInSeconds = 1f;
    float LowPassFilterFactor ;
    Vector3 lowPassValue = Vector3.zero;

    void Start ()
    {
        LowPassFilterFactor = AccelerometerUpdateInterval / LowPassFilterFactor;
        lowPassValue = Input.acceleration;
        EventController.Subscribe(Consts.Events.events.startLeftStick, StartMovement);
	}
	

    void StartMovement()
    {
        isMoving = true;
    }

    Vector3 LowPassFilterAccelerometer()
    {
        lowPassValue = Vector3.Lerp(lowPassValue, Input.acceleration, LowPassFilterFactor);
        return lowPassValue;
    }

    void Move(Vector3 startPos , Vector3 endPos)
    {
        if(transform.position.y <= endPos.y)
        {           
            Vector3 position = transform.position;
            position.y += Consts.Values.stickSpeed * Time.deltaTime;
            transform.position = position;
        }

    }


    void MoveToStartPos()
    {
      //  transform.DOMoveY() 



    }



    void Update ()
    {

        Vector3 acceleration = Input.acceleration;

        if (acceleration.sqrMagnitude > 1)
            acceleration.Normalize();

# if UNITY_EDITOR


        if (Input.GetKey(KeyCode.A))
        {
            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, -4.3f, 4.3f);
            pos.x -= 10f*Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, -4.3f, 4.3f);
                pos.x += 10f * Time.deltaTime;
            transform.position = pos;
        }


#endif


#if UNITY_ANDROID


        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -4.3f, 4.3f);
        position.x += LowPassFilterAccelerometer().x * Time.deltaTime * Consts.Values.stickSpeed;
        transform.position = position;


       

# endif


        
		
	}
}
