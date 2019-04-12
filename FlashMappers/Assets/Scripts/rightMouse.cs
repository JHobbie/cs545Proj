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

    void OnMouseDown()
    {
        diamondButtons.leftButton.SetActive(false);
        diamondButtons.bottomButton.SetActive(false);
        diamondButtons.topButton.SetActive(false);
        if (playerMovement.fromTop)
        {
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiTopRight>().enabled = false;
            saveData.selectedAnswer = 3;
            Debug.Log(saveData.selectedAnswer);
        }
        else if (playerMovement.fromBottom)
        {
            mainCam.GetComponent<guiBottomLeft>().enabled = false;
            mainCam.GetComponent<guiTopRight>().enabled = false;
            saveData.selectedAnswer = 3;
            Debug.Log(saveData.selectedAnswer);
        }
        else
        {
            mainCam.GetComponent<guiBottomRight>().enabled = false;
            mainCam.GetComponent<guiTopRight>().enabled = false;
            saveData.selectedAnswer = 2;
            Debug.Log(saveData.selectedAnswer);
        }
        if(saveData.selectedAnswer == saveData.questionSlot){
                saveData.chosenCard.seenYet=true;
            }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveRight());
        Debug.Log("right");
    }
}
