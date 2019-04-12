using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        saveData.numCardsLeft--;
        if (saveData.numCardsLeft == 0)
        {
            SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
        }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveLeft());
        Debug.Log("left");
    }
}
