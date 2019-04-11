using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiTextBoxes : MonoBehaviour
{
    // Start is called before the first frame update

    public guiBottomLeft bLeft;
    public guiBottomRight bRight;

    public guiTopRight tRight;

    public guiTopLeft tLeft;
    
    void Start()
    {
        bLeft = GetComponent<guiBottomLeft>();
        bRight = GetComponent<guiBottomRight>();
        tRight = GetComponent<guiTopRight>();
        tLeft = GetComponent<guiTopLeft>();

        bLeft.enabled = false;
        bRight.enabled = false;
        tRight.enabled = false;
        tLeft.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void turnOn(){
        //Generate Random Question
        //GEt answer
        //Select which box answer goes in
        //After answer selected fill in boxes from A-C
        Camera.main.GetComponent<guiBottomLeft>().enabled = true;
        Camera.main.GetComponent<guiBottomRight>().enabled = true;
        Camera.main.GetComponent<guiTopRight>().enabled = true;
        Camera.main.GetComponent<guiTopLeft>().enabled = true;
    }

    public static void turnOff(){
        Camera.main.GetComponent<guiBottomLeft>().enabled = false;
        Camera.main.GetComponent<guiBottomRight>().enabled = false;
        Camera.main.GetComponent<guiTopRight>().enabled = false;
        Camera.main.GetComponent<guiTopLeft>().enabled = false;
    }
}
