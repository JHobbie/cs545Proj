﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class newSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void returnToMain(){
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }
    public void loadFromText(){
        SceneManager.LoadScene("loadFromText", LoadSceneMode.Single);
    }
    public void loadFromQuizlet(){
        SceneManager.LoadScene("loadFromQuizlet", LoadSceneMode.Single);
    }
}
