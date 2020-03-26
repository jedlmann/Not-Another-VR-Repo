using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcheryController : MonoBehaviour
{
    public TextMesh timerText;
    public TextMesh scoreText;
    public int score;
    public float gameTimer;
    bool TimerTrue;
   
    void Start()
    {
        gameTimer = 0f;
        timerText.text = "Press Start To Play";
    }

    public void ArcheryStartButtonPressed()
    {
        if (gameTimer <= 0)
        {
            ////put all balls from skiballs into ball array
            //balls = SkiBalls.GetComponentsInChildren<SkiballScript>();
            //set variables to (re)start game
            score = 0;
            //update text in unity
            scoreText.text = "Score: " + Mathf.Floor(score);
            gameTimer = 45f;
            timerText.text = "Score: " + Mathf.Floor(score);
            TimerTrue = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (TimerTrue == true)
        {
            //subtracts 1 second from game timer
            gameTimer -= Time.deltaTime;
        }


        //check game timer is greater than 0 
        if (gameTimer > 0f)
        {
            //update text in unity
            timerText.text = "GAME TIME: " + Mathf.Floor(gameTimer);

        }

        // game timer less than 0 seconds
        else if (gameTimer < 0)
        {
            timerText.text = "GAME OVER";
            TimerTrue = false;

        }
    }
}
