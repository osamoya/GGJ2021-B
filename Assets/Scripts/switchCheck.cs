using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCheck : MonoBehaviour
{
    private bool Red;
    private bool Green;
    private bool Blue;
    private Collider2D swich;//switchだと名前がかぶるのでswichです。間違えてないよ(・∇・)
    // Start is called before the first frame update
    void Start()
    {
        if (this.tag == "RSwitch") Red = true;
        if (this.tag == "GSwitch") Green = true;
        if (this.tag == "BSwitch") Blue = true;
        swich = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //gMScript.backR=背景の色(今踏んでいるスイッチの加算色)
        //Red=このスクリプトがついているスイッチの色
        swich.isTrigger = true;
        if (gMScript.backR && gMScript.backG && gMScript.backB)//White
        {
            if (!Red && !Green && !Blue) swich.isTrigger = false;//Black
        }
        if (!gMScript.backR && gMScript.backG && gMScript.backB)//Cyan
        {
            if (Red && !Green && !Blue) swich.isTrigger = false;//Red
        }
        if (gMScript.backR && !gMScript.backG && gMScript.backB)//Magenta
        {
            if (!Red && Green && !Blue) swich.isTrigger = false;//Green
        }
        if (gMScript.backR && gMScript.backG && !gMScript.backB)//Yellow
        {
            if (!Red && !Green && Blue) swich.isTrigger = false;//Blue
        }
        if (!gMScript.backR && !gMScript.backG && gMScript.backB)//Blue
        {
            if (Red && Green && !Blue) swich.isTrigger = false;//Yellow
        }
        if (!gMScript.backR && gMScript.backG && !gMScript.backB)//Green
        {
            if (Red && !Green && Blue) swich.isTrigger = false;//Magenta
        }
        if (gMScript.backR && !gMScript.backG && !gMScript.backB)//Red
        {
            if (!Red && Green && Blue) swich.isTrigger = false;//Yellow
        }
        if (!gMScript.backR && !gMScript.backG && !gMScript.backB)//Black
        {
            if (Red && Green && Blue) swich.isTrigger = false;//White
        }
    }
}
