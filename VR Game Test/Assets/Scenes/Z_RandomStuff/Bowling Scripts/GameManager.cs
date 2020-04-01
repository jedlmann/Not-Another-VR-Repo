using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] pinsPrefab;

private
    
    void SpawnAll()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(pinsPrefab[i], pinsPrefab[i].transform.position, pinsPrefab[i].transform.rotation);
        }
        
    }
    void Awake()
    {
        SpawnAll();
    }
}
