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
            //gameManager.backColorR = true;
        }

        if (collision.gameObject.tag == "GSwitch")
        {
            //gameManager.backColorG = true;
        }

        if (collision.gameObject.tag == "BSwitch")
        {
            //gameManager.backColorB = true;
        }
    }        
      
    }

