using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPins : MonoBehaviour
{
    public Transform pin; //pin position
    public float threshold = .6f; //topple threshold
    public int point = 1; // point
    public BowlingController score; // score


    private void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<BowlingController>();
    }


    void OnCollisionEnter(Collision collision)
    {
        GameObject TheBowlingGameController = GameObject.Find("TheBowlingGameController");
        BowlingController TheBowlingGameControllerScript = TheBowlingGameController.GetComponent<BowlingController>();

        if (TheBowlingGameControllerScript.gameTimer > 0 && pin.up.y < threshold)
        {
            if (collision.collider.name == "100")
            {
                //increase score
                TheBowlingGameControllerScript.score += 10;

            }
            //update text in unity
            TheBowlingGameControllerScript.scoreText.text = "Score: " + Mathf.Floor(TheBowlingGameControllerScript.score); //ArcheryController.scoreText.text = "Score: " + Mathf.Floor(ArcheryControllerScript.score);
        }

        /* void CheckifFail()*/
        {
            try
            {
                if (pin.up.y < threshold)
                {
                    TheBowlingGameControllerScript.score += 1;
                    gameObject.GetComponent<Collider>().enabled = false;
                }
            }
            catch
            {
                Debug.Log("Looks like the pin went into the Dead Zone!");

            }


        }
        /*private void OnTriggerEnter(Collider other)
        {
            CheckifFail();
        }*/
    }
}
