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
            gMScript.backR = true;
        }

        if (collision.gameObject.tag == "GSwitch")
        {
            gMScript.backG = true;
        }

        if (collision.gameObject.tag == "BSwitch")
        {
            gMScript.backB = true;
        }
    }        
      
    }

