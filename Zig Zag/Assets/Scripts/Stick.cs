using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Stick : MonoBehaviour
{


    bool isDead;

    void Start()
    {
        
        isDead = false;
        EventController.Subscribe(Consts.Events.events.lose, Lose);
        EventController.Subscribe(Consts.Events.events.replay, Replay);
    }




    void Lose()
    {
        isDead = true;
    }


    void Replay()
    {
        isDead = false;
    }


    void Update()
    {

        Vector3 acceleration = Input.acceleration;

        #if UNITY_EDITOR

        if (!isDead)
        {

            if (Input.GetKey(KeyCode.A))
            {
                Vector3 pos = transform.position;
                pos.x = Mathf.Clamp(pos.x, -4.3f, 4.3f);
                pos.x -= 10f * Time.deltaTime;
                transform.position = pos;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 pos = transform.position;
                pos.x = Mathf.Clamp(pos.x, -4.3f, 4.3f);
                pos.x += 10f * Time.deltaTime;
                transform.position = pos;
            }

        }
        #endif


        #if UNITY_ANDROID

        if (!isDead)
        {

            Vector3 position = transform.position;
            position.x = Mathf.Clamp(position.x, -4.3f, 4.3f);
            position.x += acceleration.x * Time.deltaTime * Consts.Values.stickSpeed;
            transform.position = position;
        }

        #endif
      
    }
}

