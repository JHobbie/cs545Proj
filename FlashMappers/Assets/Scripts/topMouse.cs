using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topMouse : MonoBehaviour
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
        diamondButtons.leftButton.SetActive(false);
        diamondButtons.rightButton.SetActive(false);
        diamondButtons.bottomButton.SetActive(false);
        Debug.Log("top"); 
    }
}
