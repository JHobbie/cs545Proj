using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiTextBoxes : MonoBehaviour
{
    // Start is called before the first frame update

    public guiBottomLeft bLeft;
    public guiBottomRight bRight;

    public guiTopRight tRight;

    public guiTopLeft tLeft;
    
    void Start()
    {
        bLeft = GetComponent<guiBottomLeft>();
        bRight = GetComponent<guiBottomRight>();
        tRight = GetComponent<guiTopRight>();
        tLeft = GetComponent<guiTopLeft>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
