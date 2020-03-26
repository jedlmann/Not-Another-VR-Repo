using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkiballScript: MonoBehaviour
{
    //values for ball return spawn
    public float BallReturnX = -0.01f;
    public float BallReturnY = 0.65f;
    public float BallReturnZ = 4.1f;
    


    //Mole is Created
    private void Awake()
    {
       
        
    }

    

    // Update is called once per frame
    void Update()
    {
        //GameObject SkiGameController = GameObject.Find("SkiGameController");
        //SkiGameController SkiGameControllerScript = SkiGameController.GetComponent<SkiGameController>();

        //if (SkiGameControllerScript.gameTimer > 0)

        //{ 
        //    //move mole to new X, Y, Z position 
        //    transform.localPosition = Vector3.Lerp(transform.localPosition, myNewXYZPosition, Time.deltaTime * speed);

           
        //}

    }



    //collision between ball and hole
    void OnCollisionEnter(Collision collision)
    {
        GameObject TheSkiGameController = GameObject.Find("TheSkiGameController");
        TheSkiGameController TheSkiGameControllerScript = TheSkiGameController.GetComponent<TheSkiGameController>();

        if (TheSkiGameControllerScript.gameTimer > 0)
        {
            if (collision.collider.name == "100")
            {
                //increase score
                TheSkiGameControllerScript.score += 100;
                returnBall();
            }

            if (collision.collider.name == "50")
            {
                //increase score
                TheSkiGameControllerScript.score += 50;
                returnBall();
            }

            if (collision.collider.name == "30")
            {
                //increase score
                TheSkiGameControllerScript.score += 30;
                returnBall();
            }

            if (collision.collider.name == "20")
            {
                //increase score
                TheSkiGameControllerScript.score += 20;
                returnBall();

            }

            if (collision.collider.name == "10")
            {
                //increase score
                TheSkiGameControllerScript.score += 10;
                returnBall();

            }

            if (collision.collider.name == "0")
            {

                returnBall();

            }

            //update text in unity
            TheSkiGameControllerScript.scoreText.text = "Score: " + Mathf.Floor(TheSkiGameControllerScript.score); //ArcheryController.scoreText.text = "Score: " + Mathf.Floor(ArcheryControllerScript.score);
        }

        if (TheSkiGameControllerScript.gameTimer <= 0)
        {
            if (collision.collider.tag == "hole")
            {
                returnBall();
            }

           
        }
    }
        //return the ball
        public void returnBall()
    {
        //set ball's position to come out return pipe
        transform.localPosition = new Vector3(BallReturnX, BallReturnY, BallReturnZ);
    }

}
