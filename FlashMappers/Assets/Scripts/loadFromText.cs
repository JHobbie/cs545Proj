using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadFromText : MonoBehaviour
{
  public GameObject FlashCard;
  public void addFlashCard(){
      GameObject newFlashCard;
      newFlashCard = Instantiate(FlashCard);
  }
}
