using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Collider pinCollider;

    public float BallReturnX;
    public float BallReturnY;
    public float BallReturnZ;

    Rigidbody ballBody;

    private void Awake()
    {
        //set ball return coordinates
        BallReturnX = -0.474f;
        BallReturnY = 1.456f;
        BallReturnZ = -0.84f;

        //grab rigid body component of ball
        ballBody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            GameObject TheBowlingGameController = GameObject.Find("TheBowlingGameController");
            BowlingController TheBowlingGameControllerScript = TheBowlingGameController.GetComponent<BowlingController>();

           

            //put ball into ball return and set velocity to 0
            transform.localPosition = new Vector3(BallReturnX, BallReturnY, BallReturnZ);
            ballBody.velocity = new Vector3(0.0f, 0, 0);



        }
    }


}

