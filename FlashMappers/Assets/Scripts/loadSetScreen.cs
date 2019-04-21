using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using UnityEngine.SceneManagement;

public class loadSetScreen : MonoBehaviour
{
    public Dropdown loadDropdown;

    private string saveLocation;
    private List<string> paths;
    // Start is called before the first frame update
    void Start()
    {
        List<string> fileNames = new List<string>();
        DirectoryInfo d = new DirectoryInfo(Application.persistentDataPath);
        FileInfo[] Files = d.GetFiles("*.sav");
        foreach (FileInfo file in Files)
        {
            fileNames.Add(file.Name);
        }
        loadDropdown.AddOptions(fileNames);
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void returnToMain()
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }
    public void loadAndPlay()
    {
        if (loadDropdown.options.Count > 0)
        {
            string name = loadDropdown.options[loadDropdown.value].text;
            saveData.loadedCards = Serializer.Load<setOfCards>(Serializer.GetPath(name));
            for( int i = 0; i < saveData.loadedCards.allCards.Count; i++){
                saveData.loadedCards.allCards[i].seenYet = false;
            }
            Debug.Log(name);
            SceneManager.LoadScene("game", LoadSceneMode.Single);
        }

    }
}
