using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static bool fromLeft;
    public static bool fromRight;
    public static bool fromTop;
    public static bool fromBottom;
    private float speeed = 0.2f;

    void Start()
    {
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
            StartCoroutine(moveAfterAnswer());
        }
    }

    IEnumerator moveAfterAnswer(){

        /*
        top button
        bottom button
        left button
        right button

        in each, check which direction you came from and the direction you are goiong to
        then flip the bools to work correctly
         */
        
        yield return null;
    }
    

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
            diamondButtons.toggleLeft();
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
            diamondButtons.toggleRight();
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
            diamondButtons.toggleBottom();
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
            diamondButtons.toggleTop();
            qPanel.DisplayQ();
        }
        else{
            yield return null;
        }
    }

}
