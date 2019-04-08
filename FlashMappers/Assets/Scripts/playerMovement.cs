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
    private float speeed = 0.2f;

    //public void waitForOne();
    //public Scene currScene;
    void Start()
    {
        //StartCoroutine(waiter());
        //currScene = SceneManager.GetActiveScene();
        fromLeft = true;
        fromRight = false;
        fromTop = false;
        fromBottom = false;
        StartCoroutine(waitForOne());
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //moving the player until they activate the question
        if(fromLeft){
            for(float i=transform.position.x; i <= -10.05f; i+=0.05f){
                if(transform.position.x != -10.05){
                    transform.position = new Vector3(transform.position.x + 0.05f, transform.position.y, transform.position.z);
                }
                //WaitForSeconds(1);
            }
            fromLeft = false;
            //StartCoroutine(waitForAnswer());
        }
        else if(fromRight){
            while(transform.position.x != 29f){
                transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z);
            }
            fromRight = false;
            //StartCoroutine(waitForAnswer());
        }
        else if(fromBottom){
            while(transform.position.y != 14f){
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
                
            }
            fromBottom = false;
            //StartCoroutine(waitForAnswer());
        }
        else if (fromTop){
            while(transform.position.y != 12.5){
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
            }
            fromTop = false;
            //StartCoroutine(waitForAnswer());
        }
        else{
            return;
        }
        */
    }
/*
    public static void answeredUp(){
        if(fromLeft){
            //
            //movement code for going right then
        }
        else if(fromRight){

        }
        else if(fromBottom){

        }
        //fromTop
        else{

        }
        StartCoroutine(waitForOne());
    }

    public static void answeredDown(){
        if(fromLeft){
            //
            //movement code for going right then
        }
        else if(fromRight){

        }
        else if(fromBottom){

        }
        //fromTop
        else{

        }
        StartCoroutine(waitForOne());
    }

    public static void answeredLeft(){
        if(fromLeft){
            //
            //movement code for going right then
        }
        else if(fromRight){

        }
        else if(fromBottom){

        }
        //fromTop
        else{

        }
        StartCoroutine(waitForOne());
    }

    public static void answeredRight(){
        if(fromLeft){
            //
            //movement code for going right then
        }
        else if(fromRight){

        }
        else if(fromBottom){

        }
        //fromTop
        else{

        }
        StartCoroutine(waitForOne());
    }
*/
    
    IEnumerator waitForAnswer(){
        yield return new WaitForSeconds(1);
    }
    IEnumerator waitForOne(){
        //moving the player until they activate the question

        if(fromLeft){
            for(float i=transform.position.x; i <= -10.5f; i+=0.1f){
                if(transform.position.x >= -10.5f){
                    transform.position = new Vector3(-10.5f, transform.position.y, transform.position.z);
                    break;
                }
                else{
                    transform.position = new Vector3(transform.position.x + speeed, transform.position.y, transform.position.z);
                    yield return new WaitForSeconds(0.0051f);
                }
            //fromLeft = false;
            /*
                StartCoroutine(waitForAnswer());
             */
            }
        }
        else if(fromRight){
            for(float i=transform.position.x; i >= -29f; i-=0.1f){
                if(transform.position.x >= -29f){
                    transform.position = new Vector3(transform.position.x - speeed, transform.position.y, transform.position.z);
                }
                yield return new WaitForSeconds(0.0051f);
            }
            fromRight = false;
            //StartCoroutine(waitForAnswer());
        }
        else if(fromBottom){
            for(float i=transform.position.y; i <= -14f; i+=0.1f){
                if(transform.position.y <= -14f){
                    transform.position = new Vector3(transform.position.x, transform.position.y + speeed, transform.position.z);
                }
                yield return new WaitForSeconds(0.0051f);
            }
            fromBottom = false;
            //StartCoroutine(waitForAnswer());
        }
        else if (fromTop){
            for(float i=transform.position.y; i >= -12.5f; i-=0.2f){
                if(transform.position.y >= 12.5f){
                    transform.position = new Vector3(transform.position.x, transform.position.y - speeed, transform.position.z);
                }
                yield return new WaitForSeconds(0.0051f);
            }
            fromTop = false;
            //StartCoroutine(waitForAnswer());
        }
        else{
            yield return null;
        }
    }

}
