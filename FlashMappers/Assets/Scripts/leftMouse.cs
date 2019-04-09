using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        diamondButtons.bottomButton.SetActive(false);
        diamondButtons.rightButton.SetActive(false);
        diamondButtons.topButton.SetActive(false);
        Debug.Log("left"); 
    }
}
