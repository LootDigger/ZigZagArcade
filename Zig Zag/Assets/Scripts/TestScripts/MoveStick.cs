using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStick : MonoBehaviour {

    private Touch touch;

    
	

	void Update ()
    {
        if(Input.GetMouseButton(0))
        {

            Vector3 tmpPos = transform.position;
            Vector3 tmp;
            tmpPos= Camera.main.ScreenToWorldPoint( Input.mousePosition);
            tmp = transform.position;
            tmp.x = tmpPos.x;
            transform.position = tmp;
        }


    }


    //void OnMouseDrag()
    //{
    //    Vector3 tmpPos = transform.position ;
    //    tmpPos.x = Input.mousePosition.x;
    //    tmpPos.x = tmpPos.x / 2f;

    //    transform.position = tmpPos;
    //}

}
