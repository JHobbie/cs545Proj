using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topMouse : MonoBehaviour
{
    // Start is called before the first frame update
    Camera mainCam;
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        diamondButtons.leftButton.SetActive(false);
        diamondButtons.rightButton.SetActive(false);
        diamondButtons.bottomButton.SetActive(false);
        if(playerMovement.fromLeft){
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
        }
        else if(playerMovement.fromRight){
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
        }
        else{
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
        }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveUp());
        Debug.Log("top"); 
    }
}