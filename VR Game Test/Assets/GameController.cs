using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   
    public TextMesh timerText;
    public TextMesh scoreText;
    public int score;

    //30 seconds for game timer
    public float gameTimer = 30f;

    // MOLE VARIABLES
    
    public GameObject moleContainer;
   
    //array for moles inside container
    private MoleScript[] moles;

    //show mole every 1.5 seconds 
    public float showMoletimer = 1.5f;

    void Start()
    {
        //put all moles from molecontainer into mole array
        moles = moleContainer.GetComponentsInChildren<MoleScript>();
        score = 0;
        

    }

    
    void Update()
    {

        //Debug.Log("moles is" + moles.Length);
        //update the game timer

        //subtracts 1 second from game timer
        gameTimer -= Time.deltaTime; 

        //check game timer is greater than 0 
        if (gameTimer > 0f)
        {
            //update text in unity
            timerText.text = "GAME TIME: " + Mathf.Floor(gameTimer);

            showMoletimer -= Time.deltaTime;
            //show mole is showmoletimer is 0
            if (showMoletimer < 0f)
            {
                //show random mole 
                moles[Random.Range(0, moles.Length)].showMole();

                //reset show mole timer
                showMoletimer = 1.5f;
            }
        }

        // game timer less than 0 seconds
        else
        {
            timerText.text = "GAME OVER";
        }
    }
}
