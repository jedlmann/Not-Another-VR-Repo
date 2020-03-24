using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPins : MonoBehaviour
{
    public Transform pin;
    public float threshold = .6f;
    public int point = 1;
    public BowlingScore score;


    private void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<BowlingScore>();
    }

    void CheckifFail()
    {
        try
        {
            if (pin.up.y < threshold)
            {
                score.Add(point);
                gameObject.GetComponent<Collider>().enabled = false;
            }
        }
        catch
        {
            Debug.Log("Looks like the pin went into the Dead Zone!");

        }
        
            
    }
    private void OnTriggerEnter(Collider other)
    {
        CheckifFail();
    }
}
