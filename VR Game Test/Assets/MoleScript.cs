using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleScript : MonoBehaviour
{
    //values for Y when moles are hidden/shown
    public float visibleYHeight = 31.0f;
    public float hiddenYHeight = 28.0f;

    //position to move current Mole
    private Vector3 myNewXYZPosition;
   
    //speed of mole movement
    public float speed = 4f;

    //hide mole timer
    public float hideMoletimer = 1.5f;

    //Mole is Created
    private void Awake()
    {
        hideMole();

        //set current position
        transform.localPosition = myNewXYZPosition;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move mole to new X, Y, Z position 
        transform.localPosition = Vector3.Lerp(transform.localPosition, myNewXYZPosition, Time.deltaTime * speed);

        //hide mole if hidemole timer is less than 0

        hideMoletimer -= Time.deltaTime;

        if (hideMoletimer < 0)
        {
            hideMole();
        }

    }

    public void OnMouseDown()
    {
        hideMole();
        GameObject GameController = GameObject.Find("GameController");
        GameController GameControllerScript = GameController.GetComponent<GameController>();
        GameControllerScript.score += 1;

        //update text in unity
        GameControllerScript.scoreText.text = "Score: " + Mathf.Floor(GameControllerScript.score);

        Debug.Log(GameControllerScript.score);
    }

    //hide the mole
    public void hideMole()
    {
        //set mole's position to hidden
        myNewXYZPosition = new Vector3(transform.localPosition.x, hiddenYHeight, transform.localPosition.z);
    }

    public void showMole()
    {
        //set current position to visible Y height
        myNewXYZPosition = new Vector3(transform.localPosition.x, visibleYHeight, transform.localPosition.z);
        hideMoletimer = 1.5f;
    }
}
