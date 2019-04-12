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

    void OnMouseDown()
    {
        diamondButtons.bottomButton.SetActive(false);
        diamondButtons.rightButton.SetActive(false);
        diamondButtons.topButton.SetActive(false);
        if (playerMovement.fromTop)
        {
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
            saveData.selectedAnswer = 1;
        }
        else if (playerMovement.fromBottom)
        {
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
            saveData.selectedAnswer = 1;
        }
        else
        {
            mainCam.GetComponent<guiTopRight>().enabled = false;
            mainCam.GetComponent<guiBottomRight>().enabled = false;
            saveData.selectedAnswer = 2;
        }
        if(saveData.selectedAnswer == saveData.questionSlot){
                saveData.chosenCard.seenYet=true;
            }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveLeft());
        Debug.Log("left");
    }
}
