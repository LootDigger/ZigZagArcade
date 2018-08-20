using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ScenarioController : MonoBehaviour {

    #region SerializableField
    [SerializeField]
    private GameObject leftStick;

    [SerializeField]
    private GameObject rightStick;

    [SerializeField]
    private GameObject Ball;

    [SerializeField]
    private Text acceleration;
    #endregion


    #region Values
   


    #endregion


    void Start ()
    {
        EventController.Subscribe(Consts.Events.events.startGame, StartGame);
        EventController.Subscribe(Consts.Events.events.lose, SpawnNewBall);

    }



    void StartGame()
    {
    }



    void LetDown()
    {
        leftStick.transform.DOMove(Consts.Coordinates.leftStickStartPosition, 1f);
        rightStick.transform.DOMove(Consts.Coordinates.rightStickStartPosition, 1f);
        Ball.transform.DOMove(Consts.Coordinates.ballStartPosition, 1f);

    }


    void SpawnNewBall()
    {
        Instantiate(Ball, Consts.Coordinates.ballStartPosition, Quaternion.identity);
        leftStick.transform.position = Consts.Coordinates.leftStickStartPosition;
    }


    



    void Update ()
    {
        if (Input.gyro.enabled)
        {
            acceleration.text = Input.gyro.rotationRate.ToString();
        }
        else
        {
            Input.gyro.enabled = true;
        }
	}
}
