using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject player;
    public static bool fromLeft;
    public static bool fromRight;
    public static bool fromTop;
    public static bool fromBottom;

    public Scene currScene;
    void Start()
    {
        //StartCoroutine(waiter());
        currScene = SceneManager.GetActiveScene();
        fromLeft = true;
        fromRight = false;
        fromTop = false;
        fromBottom = false;
    }

    // Update is called once per frame
    void Update()
    {
        //moving the player until they activate the question
        if(fromLeft){
            for(int i = 0; i < 25; i++){
                transform.position = new Vector3(transform.position.x + 0.3f, transform.position.y, transform.position.z);
            }
        }
        else if(fromRight){
            for(int i = 0; i < 25; i++){
                transform.position = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);
            }
        }
        else if(fromBottom){
            for(int i = 0; i < 15; i++){
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
            }
        }
        else{
            for(int i = 0; i < 15; i++){
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
            }
        }
    }

}
