using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gMScript : MonoBehaviour
{
    
    public static bool backR;//背景色にどの成分が入っているか
    public static bool backG;//全部入りで白(使わない説もある)
    public static bool backB;//全部falseで黒の予定

    public static bool plR;//自キャラの色です
    public static bool plG;
    public static bool plB;
    
    public static int gameResult;//ゲームの状況を取得する変数


    //ここからくそコード
    //デバッグ用消してもよい
    [SerializeField]
    private bool debugMode=false;//これをオンにして、デバッグスタート
    [SerializeField]
    private bool R, G, B;

    private void Update()
    {
        if (debugMode)
        {
            backR = R;backG = G; backB = B;
        }
    }

}