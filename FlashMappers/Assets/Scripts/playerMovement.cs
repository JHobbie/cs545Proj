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
        if(qPanel.isAnswered == true){
            //StartCoroutine(moveAfterAnswer());
        }
    }

/*    IEnumerator moveAfterAnswer(){
        
    }
    */

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
    
/*     IEnumerator waitForAnswer(){
        yield return new WaitForSeconds(1);
    } */
    IEnumerator waitForOne(){
        //moving the player until they activate the question

        if(fromLeft){
            for(int i = 0; i< 1000; i++){
                if(transform.position.x >= -10.5f){
                    transform.position = new Vector3(-10.5f, transform.position.y, transform.position.z);
                    break;
                }
                else{
                    transform.position = new Vector3(transform.position.x + speeed, transform.position.y, transform.position.z);
                    yield return new WaitForSeconds(0.0051f);
                }
            }
            qPanel.DisplayQ();
        }
        else if(fromRight){
            for(int i = 0; i< 1000; i++){
                if(transform.position.x <= -29f){
                    transform.position = new Vector3(-29f, transform.position.y, transform.position.z);
                    break;
                }
                else{
                    transform.position = new Vector3(transform.position.x - speeed, transform.position.y, transform.position.z);
                    yield return new WaitForSeconds(0.0051f);
                }
            }
            qPanel.DisplayQ();
        }
        else if(fromBottom){
            for(int i = 0; i< 1000; i++){
                if(transform.position.y <= 14f){
                    transform.position = new Vector3(transform.position.x, 14f, transform.position.z);
                    break;
                }
                else{
                     transform.position = new Vector3(transform.position.x, transform.position.y + speeed, transform.position.z);
                     yield return new WaitForSeconds(0.0051f);
                }
            }
            qPanel.DisplayQ();
        }
        else if (fromTop){
            for(int i = 0; i< 1000; i++){
                if(transform.position.y >= 12.5f){
                    transform.position = new Vector3(transform.position.x, 12.5f, transform.position.z);
                    break;
                }
                else{
                    transform.position = new Vector3(transform.position.x, transform.position.y - speeed, transform.position.z);
                    yield return new WaitForSeconds(0.0051f);
                }
            }
            qPanel.DisplayQ();
        }
        else{
            yield return null;
        }
    }

}
