using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class leftMouse : MonoBehaviour
{
    // Start is called before the first frame update
    Camera mainCam;
    public GameObject wrongAns;
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

            saveData.selectedAnswer = 1;
        }
        else if (playerMovement.fromBottom)
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
            rightWrong.right.Play();
            if (saveData.numCardsLeft <= 0)
            {
                StartCoroutine(playerMovement.moveLeft());
                StartCoroutine(waiting());
                
                return;
            }
        }
        else{
            wrongAns.SetActive(true);
            rightWrong.wrong.Play();
        }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveLeft());
        Debug.Log("left");
    }

    IEnumerator waiting(){
        while(!playerMovement.fromRight){
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
