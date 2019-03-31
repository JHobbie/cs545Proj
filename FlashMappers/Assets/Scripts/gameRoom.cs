using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameRoom : MonoBehaviour
{
    // Start is called before the first frame update

    /*
		By Monday:
		-person auto-runs?
		-at intersection, question pops up (one question for now)
		-person can pick their answer by tapping/clicking


		TODO:
		1. Question pops up at intersection
		2. Question can be answered through interaction
		3. Choices randomly associated with direction
		4. Person goes in direction of choice
		5. Right answers removed from queue
		6. Wrong answers are re-entered at the end
		7. Timer of some kind (count up)
		8. Music
    */
    void Start()
    {
    	//labels the current scene
	    Scene currentScene = SceneManager.GetActiveScene();
	    //gets the name of the current scene
	    string sceneName = currentScene.name;
	    //get the game object
	    GameObject player = GameObject.Find("player_tilesheet_0");
    }

    // Update is called once per frame
    void Update()
    {
	    if (sceneName == "game"){
	    	//Do stuff in the game
	    	
	    }


    }
}
