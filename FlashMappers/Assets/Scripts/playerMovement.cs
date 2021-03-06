﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool fromLeft;
    public static bool fromRight;
    public static bool fromTop;
    public static bool fromBottom;
    public static float speeed = 0.6f;

    public static GameObject player;

    private static TextMeshProUGUI topLeft;

    public static void SetTopLeft(string value)
    {
        topLeft.SetText(value);
    }
    private static TextMeshProUGUI topRight;

    public static void SetTopRight(string value)
    {
        topRight.SetText(value);
    }

    private static TextMeshProUGUI botLeft;

    public static void SetBotLeft(string value)
    {
        botLeft.SetText(value);
    }
    private static TextMeshProUGUI botRight;

    public static void SetBotRight(string value)
    {
        botRight.SetText(value);
    }

    public GameObject setWrongAns;
    private static GameObject wrongAns;
    void Start()
    {
        topLeft = GameObject.Find("TopLeftTextBox").GetComponent<TextMeshProUGUI>();
        topRight = GameObject.Find("TopRightTextBox").GetComponent<TextMeshProUGUI>();
        botLeft = GameObject.Find("BotLeftTextBox").GetComponent<TextMeshProUGUI>();
        botRight = GameObject.Find("BotRightTextBox").GetComponent<TextMeshProUGUI>();
        fromLeft = true;
        fromRight = false;
        fromTop = false;
        fromBottom = false;
        player = GameObject.Find("player_tilesheet_0");
        wrongAns=setWrongAns;
        wrongAns.SetActive(false);
        StartCoroutine(waitForOne());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
        }
    }

    private static IEnumerator waitForOne()
    {
        //moving the player until they activate the question
        guiTextBoxes.turnOff();
        wrongAns.SetActive(false);
        if (fromLeft)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (player.transform.position.x >= -10.5f)
                {
                    player.transform.position = new Vector3(-10.5f, player.transform.position.y, player.transform.position.z);
                    break;
                }
                else
                {
                    player.transform.position = new Vector3(player.transform.position.x + speeed, player.transform.position.y, player.transform.position.z);
                    yield return new WaitForSeconds(0.0051f);
                }
            }
            diamondButtons.toggleLeft();
            guiTextBoxes.turnOn();
            SetTopLeft(saveData.chosenCard.word);
        }
        else if (fromRight)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (player.transform.position.x <= 29f)
                {
                    player.transform.position = new Vector3(29f, player.transform.position.y, player.transform.position.z);
                    break;
                }
                else
                {
                    player.transform.position = new Vector3(player.transform.position.x - speeed, player.transform.position.y, player.transform.position.z);
                    yield return new WaitForSeconds(0.0051f);
                }
            }
            diamondButtons.toggleRight();
            guiTextBoxes.turnOn();
            SetTopLeft(saveData.chosenCard.word);
        }
        else if (fromBottom)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (player.transform.position.y >= -12.5f)
                {
                    player.transform.position = new Vector3(player.transform.position.x, -12.5f, player.transform.position.z);
                    break;
                }
                else
                {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.0051f);
                }
            }
            diamondButtons.toggleBottom();
            guiTextBoxes.turnOn();
            SetTopLeft(saveData.chosenCard.word);
        }
        else if (fromTop)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (player.transform.position.y <= 14f)
                {
                    player.transform.position = new Vector3(player.transform.position.x, 14f, player.transform.position.z);
                    break;
                }
                else
                {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.0051f);
                }
            }
            diamondButtons.toggleTop();
            guiTextBoxes.turnOn();
            SetTopLeft(saveData.chosenCard.word);
        }
        else
        {
            yield return null;
        }
    }

    public static IEnumerator moveUp()
    {
        Debug.Log("moving up");

        if (fromLeft)
        {
            //move to right then go up
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.x < 10.5f)
                {
                    player.transform.position = new Vector3(player.transform.position.x + speeed, player.transform.position.y, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else if (player.transform.position.y < 26)
                {
                    player.transform.position = new Vector3(10.5f, player.transform.position.y + speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(10.5f, -26f, player.transform.position.z);
                    fromLeft = false;
                    fromRight = false;
                    fromTop = false;
                    fromBottom = true;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }
        else if (fromRight)
        {
            //move to left then go up
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.x > 10.5f)
                {
                    player.transform.position = new Vector3(player.transform.position.x - speeed, player.transform.position.y, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else if (player.transform.position.y < 26)
                {
                    player.transform.position = new Vector3(10.5f, player.transform.position.y + speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(10.5f, -26f, player.transform.position.z);
                    fromLeft = false;
                    fromRight = false;
                    fromTop = false;
                    fromBottom = true;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }

        else
        {
            //move up
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.y < 26)
                {
                    player.transform.position = new Vector3(10.5f, player.transform.position.y + speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(10.5f, -26f, player.transform.position.z);
                    fromLeft = false;
                    fromRight = false;
                    fromTop = false;
                    fromBottom = true;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }
    }

    public static IEnumerator moveDown()
    {
        Debug.Log("moving down");

        if (fromLeft)
        {
            //move to right then go down
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.x < 10.5f)
                {
                    player.transform.position = new Vector3(player.transform.position.x + speeed, player.transform.position.y, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else if (player.transform.position.y > -26)
                {
                    player.transform.position = new Vector3(10.5f, player.transform.position.y - speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(10.5f, 26f, player.transform.position.z);
                    fromLeft = false;
                    fromRight = false;
                    fromTop = true;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }
        else if (fromRight)
        {
            //move to left then go down
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.x > 10.5f)
                {
                    player.transform.position = new Vector3(player.transform.position.x - speeed, player.transform.position.y, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else if (player.transform.position.y > -26)
                {
                    player.transform.position = new Vector3(10.5f, player.transform.position.y - speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(10.5f, 26f, player.transform.position.z);
                    fromLeft = false;
                    fromRight = false;
                    fromTop = true;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }

        else
        {
            //move down
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.y > -26)
                {
                    player.transform.position = new Vector3(10.5f, player.transform.position.y - speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(10.5f, 26f, player.transform.position.z);
                    fromLeft = false;
                    fromRight = false;
                    fromTop = true;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }
    }

    public static IEnumerator moveRight()
    {
        Debug.Log("moving right");

        if (fromBottom)
        {
            //move up then right
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.y < 0)
                {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else if (player.transform.position.x < 36f)
                {
                    player.transform.position = new Vector3(player.transform.position.x + speeed, 0, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(-36f, 0, player.transform.position.z);
                    fromLeft = true;
                    fromRight = false;
                    fromTop = false;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }
        else if (fromTop)
        {
            //move down then right
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.y > 0)
                {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else if (player.transform.position.x < 36f)
                {
                    player.transform.position = new Vector3(player.transform.position.x + speeed, 0, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(-36f, 0, player.transform.position.z);
                    fromLeft = true;
                    fromRight = false;
                    fromTop = false;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }

        else
        {
            //move right
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.x < 36f)
                {
                    player.transform.position = new Vector3(player.transform.position.x + speeed, 0, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(-36f, 0, player.transform.position.z);
                    fromLeft = true;
                    fromRight = false;
                    fromTop = false;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }
    }

    public static IEnumerator moveLeft()
    {
        Debug.Log("moving left");

        if (fromBottom)
        {
            //move up then right
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.y < 0)
                {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else if (player.transform.position.x > -36f)
                {
                    player.transform.position = new Vector3(player.transform.position.x - speeed, 0, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(36f, 0, player.transform.position.z);
                    fromLeft = false;
                    fromRight = true;
                    fromTop = false;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }
        else if (fromTop)
        {
            //move down then right
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.y > 0)
                {
                    player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - speeed, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else if (player.transform.position.x > -36f)
                {
                    player.transform.position = new Vector3(player.transform.position.x - speeed, 0, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(36f, 0, player.transform.position.z);
                    fromLeft = false;
                    fromRight = true;
                    fromTop = false;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }

        else
        {
            //move left
            for (int i = 0; i < 2000; i++)
            {
                if (player.transform.position.x > -36f)
                {
                    player.transform.position = new Vector3(player.transform.position.x - speeed, 0, player.transform.position.z);
                    yield return new WaitForSeconds(0.00051f);
                }
                else
                {
                    player.transform.position = new Vector3(36f, 0, player.transform.position.z);
                    fromLeft = false;
                    fromRight = true;
                    fromTop = false;
                    fromBottom = false;
                    if (saveData.numCardsLeft <= 0)
                    {
                        yield break;
                    }
                    player.GetComponent<playerMovement>().StartCoroutine(playerMovement.waitForOne());
                    yield break;
                }
            }
        }
    }
}