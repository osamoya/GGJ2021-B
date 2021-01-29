using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCheck : MonoBehaviour
{
    gMScript gMScript;
    [SerializeField]
    bool Red = true;//名前検討中
    bool Blue = true;//名前検討中
    bool Green = true;//名前検討中

    private Collider wall;

    void Start()
    {
        
    }
    void Update()
    {
        if(Red && gMScript.backColorR)
        {
            wall.isTrigger = true;
             Blue = false;//名前検討中
             Green = false;//名前検討中
        }
    }
}
