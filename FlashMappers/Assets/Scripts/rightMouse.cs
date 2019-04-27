using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rightMouse : MonoBehaviour
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
            rightWrong.right.Play();
            if (saveData.numCardsLeft <= 0)
            {
                StartCoroutine(playerMovement.moveRight());
                StartCoroutine(waiting());
                return;
            }
        }
        else
        {
            wrongAns.SetActive(true);
            rightWrong.wrong.Play();
        }
        playerMovement.player.GetComponent<playerMovement>().StartCoroutine(playerMovement.moveRight());
        Debug.Log("right");
    }

    IEnumerator waiting()
    {
        while (!playerMovement.fromLeft)
        {
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
        transform.localScale = new Vector3(1.703812F, 1.703812F, 1.703812F);
    }
}
