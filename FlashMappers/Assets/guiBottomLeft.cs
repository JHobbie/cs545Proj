using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiBottomLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){
        GUI.Box(new Rect(0, 0, Screen.width/3, Screen.height/2), "I want to be the very best, like no one ever was. To catch them is my real test. To train them is my cause.");
    }
}
