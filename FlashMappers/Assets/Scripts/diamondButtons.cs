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

    public static Sprite letterA;
    public static Sprite letterB;
    public static Sprite letterC;

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

        letterA = Resources.Load<Sprite>("letter_A");
        letterB = Resources.Load<Sprite>("letter_B");
        letterC = Resources.Load<Sprite>("letter_C");

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

        leftButton.GetComponent<SpriteRenderer>().sprite = letterA;
        bottomButton.GetComponent<SpriteRenderer>().sprite = letterB;
        rightButton.GetComponent<SpriteRenderer>().sprite = letterC;
        
    }

    public static void toggleBottom(){
        topButton.SetActive(true);
        bottomButton.SetActive(false);
        rightButton.SetActive(true);
        leftButton.SetActive(true);

        leftButton.GetComponent<SpriteRenderer>().sprite = letterA;
        topButton.GetComponent<SpriteRenderer>().sprite = letterB;
        rightButton.GetComponent<SpriteRenderer>().sprite = letterC;
    }

    public static void toggleRight(){
        topButton.SetActive(true);
        bottomButton.SetActive(true);
        rightButton.SetActive(false);
        leftButton.SetActive(true);

        topButton.GetComponent<SpriteRenderer>().sprite = letterA;
        leftButton.GetComponent<SpriteRenderer>().sprite = letterB;
        bottomButton.GetComponent<SpriteRenderer>().sprite = letterC;
    }

    public static void toggleLeft(){
        topButton.SetActive(true);
        bottomButton.SetActive(true);
        rightButton.SetActive(true);
        leftButton.SetActive(false);

        topButton.GetComponent<SpriteRenderer>().sprite = letterA;
        rightButton.GetComponent<SpriteRenderer>().sprite = letterB;
        bottomButton.GetComponent<SpriteRenderer>().sprite = letterC;
    }
}
