using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    void OnMouseDown()
    {
        diamondButtons.leftButton.SetActive(false);
        diamondButtons.rightButton.SetActive(false);
        diamondButtons.bottomButton.SetActive(false);
        if (playerMovement.fromLeft)
        {
            saveData.selectedAnswer = 1;
        }
        else if (playerMovement.fromRight)
        {
            saveData.selectedAnswer = 1;
        }
        else
        {
            saveData.selectedAnswer = 2;
        }
        if (saveData.selectedAnswer == saveData.questionSlot)
        {
            saveData.chosenCard.seenYet = true;
            saveData.numCardsLeft--;
            if (saveData.numCardsLeft <= 0)
            {
                StartCoroutine(playerMovement.moveUp());
                StartCoroutine(waiting());
                
                return;
            }
        }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveUp());
        Debug.Log("top");
    }

    IEnumerator waiting(){
        while(!playerMovement.fromBottom){
            yield return new WaitForSeconds(0.1f);
        }
        SceneManager.LoadScene("winScreen", LoadSceneMode.Single);
    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached
        transform.localScale = new Vector3(2.3F, 2.3F, 0);
        Debug.Log("hovering");
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject
        transform.localScale = new Vector3(1.703812F,1.703812F,1.703812F);
    }
}