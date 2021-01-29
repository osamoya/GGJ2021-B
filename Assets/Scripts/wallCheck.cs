using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCheck : MonoBehaviour
{
    gMScript gMScript;
    [SerializeField]
    bool Red = true;//名前検討中

    private Collider wall;

    void Start()
    {
        
    }
    void Update()
    {
        if(Red && gMScript.backColorR)
        {
            wall.isTrigger = true;
        }
    }
}
