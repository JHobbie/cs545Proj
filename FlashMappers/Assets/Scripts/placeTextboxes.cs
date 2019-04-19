using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeTextboxes : MonoBehaviour
{
    // Start is called before the first frame update
    static GameObject topLeftBox;
    static GameObject topRightBox;
    static GameObject botLeftBox;
    static GameObject botRightBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void placeBoxes(){
        topLeftBox = GameObject.Find("TopLeftTextBox");
        topRightBox = GameObject.Find("TopRightTextBox");
        botLeftBox = GameObject.Find("BotLeftTextBox");
        botRightBox = GameObject.Find("BotRightTextBox");
        /*

        topLeftBox.transform.position = new Vector3(0,0,0);;
        
        topRightBox.transform.position = new Vector3(Screen.width/3 * 2, 0, 0);

        botLeftBox.transform.position = new Vector3(0, Screen.height/3 * 2, 0);

        botRightBox.transform.position = new Vector3(Screen.width/3 *2, Screen.height/3 *2, 0);
    */}
}
