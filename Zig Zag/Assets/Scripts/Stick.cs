using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("Trigger");

        if (other.tag == "LeftStick" || other.tag == "RightStick")
        {
            Debug.Log("Touch Stick");
        }

    }

}
