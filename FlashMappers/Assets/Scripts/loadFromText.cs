using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.Networking;
using HtmlAgilityPack;
using System.Net;
public class loadFromText : MonoBehaviour
{
    public GameObject urlText;
    public GameObject setName;
    public GameObject FlashCard;
    public GameObject firstFlashCard;
    public GameObject lastFlashCard;
    public List<GameObject> cardList = new List<GameObject>();
    void Start()
    {
        cardList.Add(firstFlashCard);
    }


    public void addFlashCard()
    {
        GameObject newFlashCard;
        newFlashCard = Instantiate(FlashCard, lastFlashCard.transform.position, lastFlashCard.transform.rotation);
        newFlashCard.transform.SetParent(lastFlashCard.transform);
        newFlashCard.transform.position = new Vector3(lastFlashCard.transform.position.x, lastFlashCard.transform.position.y - 40, 1);
        newFlashCard.SetActive(true);
        lastFlashCard = newFlashCard;
        cardList.Add(newFlashCard);
    }
    public void removeFlashCard()
    {
        GameObject temp = lastFlashCard;
        if (lastFlashCard != firstFlashCard)
        {
            cardList.Remove(lastFlashCard);
            Destroy(lastFlashCard);
            lastFlashCard = temp.transform.parent.gameObject;
        }
    }
    public setOfCards saveSet()
    {
        string nameOfSet;
        setOfCards cardSet;
        try
        {
            nameOfSet = setName.GetComponent<InputField>().text;
            cardSet = new setOfCards(nameOfSet);
        }
        catch
        {
            cardSet  = new setOfCards();
        }
        GameObject currentCard;
        flashCard newCard;
        string word;
        string definition;
        for (int i = 0; i < cardList.Count; i++)
        {
            currentCard = cardList[i];
            word = currentCard.transform.Find("Word").gameObject.GetComponent<InputField>().text;
            definition = currentCard.transform.Find("Definition").gameObject.GetComponent<InputField>().text;
            newCard = new flashCard(word, definition);
            cardSet.addCard(newCard);
        }
        return cardSet;

    }
    public void newSetScreen()
    {
        SceneManager.LoadScene("newSetScreen", LoadSceneMode.Single);
    }
    public void saveAndPlay()
    {
        string name = setName.GetComponent<InputField>().text;
        setOfCards cardSet = saveSet();
        Serializer.Save<setOfCards>(Serializer.GetSavePath(name), cardSet);
        saveData.loadedCards = Serializer.Load<setOfCards>(Serializer.GetSavePath(name));
        SceneManager.LoadScene("game", LoadSceneMode.Single);
    }
    public void saveNoPlay()
    {
        string name = setName.GetComponent<InputField>().text;
        setOfCards cardSet = saveSet();
        Serializer.Save<setOfCards>(Serializer.GetSavePath(name), cardSet);
    }
    public void GetText()
    {
        string url = urlText.GetComponent<InputField>().text;
        WebClient web = new WebClient();
        try
        {
            string html = web.DownloadString(url);
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);
            try
            {
                HtmlNodeCollection flashCardsIterator = document.DocumentNode.SelectSingleNode("//div[@class='SetPage-termsList']").ChildNodes;
                string currentWord;
                string currentDef;
                int i = 0;
                foreach (HtmlNode card in flashCardsIterator)
                {
                    currentWord = card.SelectSingleNode(".//span[contains(@class, 'TermText')]").InnerHtml;
                    currentDef = card.SelectNodes(".//span[contains(@class, 'TermText')]")[1].InnerHtml;
                    cardList[i].transform.Find("Word").GetComponent<InputField>().text = currentWord;
                    cardList[i].transform.Find("Definition").GetComponent<InputField>().text = currentDef;
                    addFlashCard();
                    i++;
                }
            }
            catch (NullReferenceException e)
            {
                Debug.Log(e);
            }
        }
        catch
        {
            urlText.GetComponent<InputField>().text = "That is not a valid URL";
        }
    }
}


