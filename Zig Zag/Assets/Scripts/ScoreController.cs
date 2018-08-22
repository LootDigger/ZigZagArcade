using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour {

    [SerializeField]
    private TextMeshProUGUI mainScoreComponent;
    [SerializeField]
    private TextMeshProUGUI resultScoreComponent;

    private int score;

	void Start ()
    {
        score = 0;

        EventController.Subscribe(Consts.Events.events.jump, IncreaseScore);
        EventController.Subscribe(Consts.Events.events.lose, UpdateResult);
        EventController.Subscribe(Consts.Events.events.replay, Replay);
        mainScoreComponent.text = 0.ToString();
	}

    void IncreaseScore()
    {
        score++;
        mainScoreComponent.text = score.ToString();
    }


    void UpdateResult()
    {
        resultScoreComponent.text = score.ToString();
    }

    void Replay()
    {
        score = 0;
        mainScoreComponent.text = score.ToString();
    }
	
}
