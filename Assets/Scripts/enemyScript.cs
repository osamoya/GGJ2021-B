using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    private bool Red;//敵キャラの赤
    private bool Green;//敵キャラの緑
    private bool Blue;//敵キャラの青
    private Collider2D raze;//当たり判定のやつ


    void Start()
    {
        if (this.tag == "enemyR") Red = true;
        if (this.tag == "enemyG") Green = true;
        if (this.tag == "enemyB") Blue = true;
        raze = this.GetComponent<Collider2D>();
    }

    void Update()
    {

        
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gMScript.backR && !gMScript.backG && !gMScript.backB)//背景が赤
        {
            /*if (gMScript.plR && !gMScript.plG && !gMScript.plB)//自キャラが赤
            {
                if (!Red && !Blue && Green) gMScript.gameResult = 1;//敵キャラが緑の場合
                if (!Red && Blue && !Green) gMScript.gameResult = 1;//敵キャラが青の場合

            }*/
            /*if (!gMScript.plR && gMScript.plG && !gMScript.plB)//自キャラが緑
            {*/
            if (!Red && Blue && !Green) { gMScript.gameResult = 1; Debug.Log("死亡"); } //敵キャラが青の場合
            //}
            //if (!gMScript.plR && !gMScript.plG && gMScript.plB)//自キャラが青
            //{
            if (!Red && !Blue && Green) { gMScript.gameResult = 1; Debug.Log("死亡"); }//敵キャラが緑の場合
            //}
        }
        if (!gMScript.backR && gMScript.backG && !gMScript.backB)//背景が緑
        {
            // if (gMScript.plR && !gMScript.plG && !gMScript.plB)//自キャラが赤
            // {
            if (!Red && Blue && !Green)
            {
                gMScript.gameResult = 1;
                Debug.Log("死亡");
            }//敵キャラが青の場合

            //  }
            /*if (!gMScript.plR && gMScript.plG && !gMScript.plB)//自キャラが緑
            {
                if (Red && !Blue && !Green) gMScript.gameResult = 1;//敵キャラが赤の場合
                if (!Red && Blue && !Green) gMScript.gameResult = 1;//敵キャラが青の場合
            }*/
            // if (!gMScript.plR && !gMScript.plG && gMScript.plB)//自キャラが青
            // {
            if (Red && !Blue && !Green)
            {
                gMScript.gameResult = 1;
                Debug.Log("死亡");
            }//敵キャラが赤の場合
             // }
        }
        if (!gMScript.backR && !gMScript.backG && gMScript.backB)//背景が青
        {
            //if (gMScript.plR && !gMScript.plG && !gMScript.plB)//自キャラが赤
            //{
            if (!Red && !Blue && Green) { gMScript.gameResult = 1; Debug.Log("死亡"); }//敵キャラが緑の場合
                                                                                     //}
                                                                                     //if (!gMScript.plR && gMScript.plG && !gMScript.plB)//自キャラが緑
                                                                                     //{
            if (Red && !Blue && !Green) { gMScript.gameResult = 1; Debug.Log("死亡"); }//敵キャラが赤の場合
            //}
            /*if (!gMScript.plR && !gMScript.plG && gMScript.plB)//自キャラが青
            {
                if (Red && !Blue && !Green) gMScript.gameResult = 1;//敵キャラが赤の場合
                if (!Red && !Blue && Green) gMScript.gameResult = 1;//敵キャラが緑の場合
            }*/
        }
        if (!gMScript.backR && !gMScript.backG && !gMScript.backB)
        {
            gMScript.gameResult = 1; Debug.Log("死亡");
        }
    }
}


