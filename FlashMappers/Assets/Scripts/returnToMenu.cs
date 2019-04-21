using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goMain(){
        Serializer.Save<setOfCards>(Serializer.GetSavePath(saveData.loadedCards.setName), saveData.loadedCards);
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }
}
