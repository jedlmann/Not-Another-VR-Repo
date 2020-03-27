using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour
{
    Collider pinCollider;

    void Start()
    {
        pinCollider = GetComponent<Collider>();
    }

    
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            GameObject TheBowlingGameController = GameObject.Find("TheBowlingGameController");
            BowlingController TheBowlingGameControllerScript = TheBowlingGameController.GetComponent<BowlingController>();


            //increase score
            TheBowlingGameControllerScript.score += 1;

            //update text in unity
            TheBowlingGameControllerScript.scoreText.text = "Score: " + Mathf.Floor(TheBowlingGameControllerScript.score);

            pinCollider.enabled = false;
        }
    }
}
