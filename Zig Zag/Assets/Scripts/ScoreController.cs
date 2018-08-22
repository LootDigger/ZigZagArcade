using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour {

    [SerializeField]
    private TextMeshProUGUI mainScoreComponent;
    [SerializeField]
    private TextMeshProUGUI resultScoreComponent;
    [SerializeField]
    private TextMeshProUGUI bestResultScoreComponent;


    private int score;
    private int bestScore;

	void Start ()
    {
        score = 0;
        bestScore = 0;

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

        if (score > bestScore)
        {
            bestScore = score;
            bestResultScoreComponent.text = bestScore.ToString();
            ES2.Save(bestScore, "best.txt");

        }
        else
        {
            if (ES2.Exists("best.txt"))
            {
                bestScore = ES2.Load<int>("best.txt");
                Debug.Log("Load result");
            }
            else
                Debug.Log("Can't load best result");

        }
    }

    void Replay()
    {
        score = 0;
        mainScoreComponent.text = score.ToString(); 
    }
	
}
