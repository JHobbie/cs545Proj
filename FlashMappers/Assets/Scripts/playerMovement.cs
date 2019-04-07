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
            for(int i = 0; i < 15; i++){
                transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                
            }
            fromLeft = false;
            StartCoroutine(waitForAnswer());
        }
        else if(fromRight){
            for(int i = 0; i < 25; i++){
                transform.position = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);

            }
            fromRight = false;
            StartCoroutine(waitForAnswer());
        }
        else if(fromBottom){
            for(int i = 0; i < 15; i++){
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
                
            }
            fromBottom = false;
            StartCoroutine(waitForAnswer());
        }
        else if (fromTop){
            for(int i = 0; i < 15; i++){
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
            }
            fromTop = false;
            StartCoroutine(waitForAnswer());
        }
        else{
            return;
        }
    }

    IEnumerator waitForAnswer(){
        yield return new WaitForSeconds(4);
    }

}
