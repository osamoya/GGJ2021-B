using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rrazer")
        {
            //if (gMScript.plR) { gMScript.plR = false; } else { gMScript.plR = true; }
        }

        if (collision.gameObject.tag == "Grazer")
        {
            //if (gMScript.plG) { gMScript.plG = false; } else { gMScript.plG = true; }
        }

        if (collision.gameObject.tag == "Brazer")
        {
            //if (gMScript.plB) { gMScript.plB = false; } else { gMScript.plB = true; }
        }
    }
}
