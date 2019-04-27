using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightWrong : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioSource wrong;
    public static AudioSource right;

    
    //public GameObject soundEffects;

    void Start()
    {
        var aSources = GetComponents<AudioSource>();
        wrong = aSources[1];
        right = aSources[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
