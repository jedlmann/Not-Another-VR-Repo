using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPins : MonoBehaviour
{
    public Transform pin; //pin position
    public float threshold = .6f; //topple threshold
    public int point = 1; // point
    public BowlingScore score; // score


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
