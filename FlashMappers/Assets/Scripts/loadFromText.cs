using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadFromText : MonoBehaviour
{
  public GameObject FlashCard;
  public GameObject firstFlashCard;
  public GameObject lastFlashCard;
  public void addFlashCard(){
      GameObject newFlashCard;
      newFlashCard = Instantiate(FlashCard, lastFlashCard.transform.position, lastFlashCard.transform.rotation);
      newFlashCard.transform.SetParent(lastFlashCard.transform);
      newFlashCard.transform.position = new Vector3(lastFlashCard.transform.position.x, lastFlashCard.transform.position.y - 40, 1);
      newFlashCard.SetActive(true);
      lastFlashCard = newFlashCard;
  }
  public void removeFlashCard(){
      GameObject temp = lastFlashCard;
      if (lastFlashCard != firstFlashCard){
        Destroy(lastFlashCard);
        lastFlashCard = temp.transform.parent.gameObject;
      }
  }
  public void newSetScreen(){
    SceneManager.LoadScene("newSetScreen",LoadSceneMode.Single);
  }
}
