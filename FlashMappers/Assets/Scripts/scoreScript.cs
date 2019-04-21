using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text=score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score= saveData.loadedCards.allCards.Count-saveData.numCardsLeft;
        scoreText.text=score.ToString();
    }
}
