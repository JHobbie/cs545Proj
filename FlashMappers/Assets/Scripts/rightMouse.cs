using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightMouse : MonoBehaviour
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
        diamondButtons.bottomButton.SetActive(false);
        diamondButtons.topButton.SetActive(false);
        if(playerMovement.fromTop){
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
        }
        else if(playerMovement.fromBottom){
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiTopRight>().enabled = false;
        }
        else{
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiTopRight>().enabled = false;
        }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveRight());
        Debug.Log("right"); 
    }
}
