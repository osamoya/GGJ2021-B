﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gMScript : MonoBehaviour
{
    [SerializeField]private UIManageScript UIM;
    public static bool backR;//背景色にどの成分が入っているか
    public static bool backG;//全部入りで白(使わない説もある)
    public static bool backB;//全部falseで黒の予定

    public static bool plR;//自キャラの色です
    public static bool plG;
    public static bool plB;

    [SerializeField] public static int gameResult;//ゲームの状況を取得する変数

    [SerializeField] public static int nowStageNum;//0…ステージ以外。1～…遊べるステージ

    [SerializeField] private float animeTime;//足されていくやつ


    //ここからくそコード
    //デバッグ用消してもよい
    [SerializeField]
    private bool debugMode=false;//これをオンにして、デバッグスタート
    [SerializeField]
    private bool R, G, B;
    [SerializeField]
    private int stage;

    private void Start()
    {
        animeTime = 0f;
        backR = backG = backB = false;
        gameResult = 0;
    }

    private void Update()
    {
        //Debug.Log("gameResult："+gameResult);//デバッグ用

        //----------------------------------------デバッグ用
        if (debugMode)
        {
            backR = R;backG = G; backB = B;
            gMScript.nowStageNum = stage;
        }
        //----------------------------------------デバッグ終了

        if (gameResult == -1)//クリア
        {
            Debug.Log("シーン読み込み");
            backR = backG = backB = false;
            UIM.LoadOver("StageClear");
        }
        if (gameResult==1)//ミス
        {
            animeTime += Time.deltaTime;
            if (animeTime>=2.0f)
            {
                Debug.Log("ミスの判定");
                ResetStage();
                UIM.LoadName("stage" + nowStageNum);
            }
            
        }
    }

    public static void ResetStage()
    {
        backR= backG= backB=false;
        gameResult = 0;
}

}