using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Hammer" || collision.collider.name == "Player")
        {
            //referece GameController Script

            GameObject GameController = GameObject.Find("GameController");
            GameController GameControllerScript = GameController.GetComponent<GameController>();

            GameControllerScript.StartButtonPressed();
        }

    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}
