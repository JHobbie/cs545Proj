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
    public setOfCards loadedCards;
    private string saveLocation;
    private List<string> paths;
    // Start is called before the first frame update
    void Start()
    {
        List<string> fileNames = new List<string>();
        DirectoryInfo d = new DirectoryInfo(Application.persistentDataPath);
        FileInfo[] Files = d.GetFiles("*.sav");
        foreach(FileInfo file in Files){
            fileNames.Add(file.Name);
        }
        saveLocation = Application.persistentDataPath;
        string[] pathNames = Directory.GetFiles(saveLocation);
        paths = pathNames.OfType<string>().ToList();
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
        string name = paths[loadDropdown.value];
        loadedCards = Serializer.Load<setOfCards>(Serializer.GetSavePath(name));
        SceneManager.LoadScene("game", LoadSceneMode.Single);
    }
}
