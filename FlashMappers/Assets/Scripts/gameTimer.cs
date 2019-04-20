using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public string minutes;
    public string seconds;

    public Text timerText;
    void Start()
    {
        //timerText = GetComponent("Text");
    }

    // Update is called once per frame
    void Update(){
        //this is for counting up
        timer += Time.deltaTime;
 
        minutes = Mathf.Floor(timer / 60).ToString("00");
        seconds = (timer % 60).ToString("00");
     
        timerText.text = minutes + ":" + seconds;
    }
}
