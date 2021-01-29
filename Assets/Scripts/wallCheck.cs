using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCheck : MonoBehaviour
{
    gMScript gMScript;
    [SerializeField]
    bool Red = false;//名前検討中
    [SerializeField]
    bool Blue = false;//名前検討中
    [SerializeField]
    bool Green = false;//名前検討中

    private Collider wall;

    void Start()
    {
        
    }
    void Update()
    {
        wall.isTrigger = false;
        if (gMScript.backR && gMScript.backG && gMScript.backB)//1
        {
            if (Red && Green && Blue) wall.isTrigger = true;
        }
        if (!gMScript.backR && gMScript.backG && gMScript.backB)//2
        {
            if (!Red && Green && Blue) wall.isTrigger = true;
        }
        if (gMScript.backR && !gMScript.backG && gMScript.backB)//3
        {
            if (Red && !Green && Blue) wall.isTrigger = true;
        }
        if (gMScript.backR && gMScript.backG && !gMScript.backB)//4
        {
            if (Red && Green && !Blue) wall.isTrigger = true;
        }
        if (!gMScript.backR && !gMScript.backG && gMScript.backB)//5
        {
            if (!Red && !Green && Blue) wall.isTrigger = true;
        }
        if (!gMScript.backR && gMScript.backG && !gMScript.backB)//6
        {
            if (!Red && Green && !Blue) wall.isTrigger = true;
        }
        if (gMScript.backR && !gMScript.backG && !gMScript.backB)//7
        {
            if (Red && !Green &&! Blue) wall.isTrigger = true;
        }
        if (!gMScript.backR && !gMScript.backG && !gMScript.backB)//8
        {
            if (!Red && !Green && !Blue) wall.isTrigger = true;
        }
    }
}
