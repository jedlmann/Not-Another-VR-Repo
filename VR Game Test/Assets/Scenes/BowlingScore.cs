using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlingScore : MonoBehaviour
{
    public int score = 0;
    public TextMesh text; 

    public void Add(int amount)
    {
        score += amount;
    }

    private void Start()
    {
        {
            score = 0;
        }
    }
    void UpdateDisplay()
    {
        text.text = "Score " + score;
    }
}
