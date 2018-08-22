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
    private GameObject Ball;


    [SerializeField]
    private GameObject gameOverMenu;

    #endregion


    #region Values


    #endregion


    void Start ()
    {
        EventController.Subscribe(Consts.Events.events.startGame, StartGame);
        EventController.Subscribe(Consts.Events.events.lose, ShowGameOverScreen);
        EventController.Subscribe(Consts.Events.events.replay, Replay);


    }



    void StartGame()
    {
    }


    void Replay()
    {
        
        gameOverMenu.transform.DOMoveX(-15f, 1f);
        leftStick.transform.position = Consts.Coordinates.leftStickStartPosition;
        StartCoroutine(CountDown());
    }
   


    void SpawnNewBall()
    {
        Instantiate(Ball, Consts.Coordinates.ballStartPosition, Quaternion.identity);
        
    }


    void ShowGameOverScreen()
    {
        gameOverMenu.transform.DOMoveX(0, 1f);
    }
    

    IEnumerator CountDown()
    {
        
        yield return new WaitForSeconds(1f);
        SpawnNewBall();
    }



    void Update ()
    {
        
	}
}
