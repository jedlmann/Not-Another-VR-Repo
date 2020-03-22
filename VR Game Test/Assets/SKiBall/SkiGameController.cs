using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiGameController : MonoBehaviour
{
   
    public TextMesh timerText;
    public TextMesh scoreText;
    public int score;
    public float gameTimer;
    bool TimerTrue;

    // Ball VARIABLES
    
    public GameObject SkiBalls;
   
    //array for balls inside container
    private SkiballScript[] balls;


    void Start()
    {
        
        gameTimer = 0f;
        timerText.text = "Press Start To Play";


    }

    public void StartButtonPressed()
    {
        if (gameTimer <= 0)
        {
            //put all balls from skiballs into ball array
            balls = SkiBalls.GetComponentsInChildren<SkiballScript>();
            //set variables to (re)start game
            score = 0;
            gameTimer = 45f;
            TimerTrue = true;
        }
    }
    
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
