using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamondButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject topButton;
    public static GameObject leftButton;
    public static GameObject rightButton;
    public static GameObject bottomButton;

    void Start()
    {
        topButton = GameObject.FindGameObjectsWithTag("TopButton")[0];
        bottomButton = GameObject.FindGameObjectsWithTag("BottomButton")[0];
        leftButton = GameObject.FindGameObjectsWithTag("LeftButton")[0];
        rightButton = GameObject.FindGameObjectsWithTag("RightButton")[0];

        topButton.SetActive(false);
        bottomButton.SetActive(false);
        rightButton.SetActive(false);
        leftButton.SetActive(false);

        //Debug.Log();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //scale = 1.703812 for each

    public static void toggleButtonsOff(){
        topButton.SetActive(false);
        bottomButton.SetActive(false);
        rightButton.SetActive(false);
        leftButton.SetActive(false);
    }

    public static void toggleTop(){
        topButton.SetActive(false);
        bottomButton.SetActive(true);
        rightButton.SetActive(true);
        leftButton.SetActive(true);
    }

    public static void toggleBottom(){
        topButton.SetActive(true);
        bottomButton.SetActive(false);
        rightButton.SetActive(true);
        leftButton.SetActive(true);
    }

    public static void toggleRight(){
        topButton.SetActive(true);
        bottomButton.SetActive(true);
        rightButton.SetActive(false);
        leftButton.SetActive(true);
    }

    public static void toggleLeft(){
        topButton.SetActive(true);
        bottomButton.SetActive(true);
        rightButton.SetActive(true);
        leftButton.SetActive(false);
    }
}
