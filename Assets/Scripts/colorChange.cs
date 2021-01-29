using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{

    void Start()
    {
        
    }    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RSwitch")
        {
            //gMScript.backColorR = true;
        }

        if (collision.gameObject.tag == "GSwitch")
        {
            //gMScript.backColorG = true;
        }

        if (collision.gameObject.tag == "BSwitch")
        {
            //gMScript.backColorB = true;
        }
    }        
      
    }

