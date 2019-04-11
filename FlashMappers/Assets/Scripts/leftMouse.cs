using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMouse : MonoBehaviour
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
        diamondButtons.bottomButton.SetActive(false);
        diamondButtons.rightButton.SetActive(false);
        diamondButtons.topButton.SetActive(false);
        if(playerMovement.fromTop){
            mainCam.GetComponent<guiTopRight>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
        }
        else if(playerMovement.fromBottom){
            mainCam.GetComponent<guiTopRight>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
        }
        else{
            mainCam.GetComponent<guiTopRight>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
        }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveLeft());
        Debug.Log("left"); 
    }
}
