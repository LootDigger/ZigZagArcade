using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Lerp : MonoBehaviour {

    Vector3 endPosition = new Vector3(5, 5, 0);
    Vector3 startPos;
    float t = 0;
	void Start ()
    {
        startPos = transform.position;
	}
	
	void Update ()
    {
        t += 0.001f;
      transform.position =  Vector3.Lerp(startPos, endPosition, t);
		
	}
}
