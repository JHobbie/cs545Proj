using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            saveData.selectedAnswer = 3;
            Debug.Log(saveData.selectedAnswer);
        }
        else if (playerMovement.fromBottom)
        {
            saveData.selectedAnswer = 3;
            Debug.Log(saveData.selectedAnswer);
        }
        else
        {
            saveData.selectedAnswer = 2;
            Debug.Log(saveData.selectedAnswer);
        }
        if (saveData.selectedAnswer == saveData.questionSlot)
        {
            saveData.chosenCard.seenYet = true;
            saveData.numCardsLeft--;
            if (saveData.numCardsLeft == 0)
            {
                SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
            }
        }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveRight());
        Debug.Log("right");
    }
}
