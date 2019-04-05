using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject player;
    public bool goingLeft;
    public bool goingRight;
    public bool goingUp;
    public bool goingDown;

    public Scene currScene;
    void Start()
    {
        currScene = SceneManager.GetActiveScene();
        goingLeft = false;
        goingRight = false;
        goingUp = false;
        goingDown = false;
        if(currScene.name == "game"){
            goingLeft = true;
        }
        else if(currScene.name == "game2"){
            goingRight = true;
        }
        else if(currScene.name == "game3"){
            goingUp = true;
        }
        else{
            goingDown = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //moving the player until they activate the question
        if(goingLeft){
            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
        else if(goingRight){
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        }
        else if(goingUp){
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
        }
        else{
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
        }

    }
}
