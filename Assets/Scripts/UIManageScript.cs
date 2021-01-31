using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// UIに関するエトセトラ
/// シーンを呼び出したり、重ね掛けしたり
/// </summary>
public class UIManageScript : MonoBehaviour
{
    private bool OverScene;//現在上にシーンがかかっているかどうか
    // Start is called before the first frame update
    void Start()
    {
        OverScene = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadName(string name) { SceneManager.LoadScene(name); }//以上

    /// <summary>
    /// シーンを上から重ねる関数
    /// すでにあったら拒否ります
    /// </summary>
    /// <param name="name"></param>
    public void LoadOver(string name) {
        if (!OverScene)
        {
            Debug.Log("重ねます");
            OverScene = true; SceneManager.LoadScene(name, LoadSceneMode.Additive);//なければつける
        }
        else Debug.Log("すでに重なってます！");//デバッグ用
    }
    public void NextStage()
    {
        Debug.Log("ステージクリア後、呼ばれる");
        if (gMScript.nowStageNum <= 5)
        {
            gMScript.nowStageNum++;
            string sname = "Stage"+gMScript.nowStageNum;
            LoadName(sname);
        }
        else
        {
            Debug.Log("タイトルへ");
            LoadName("TitleScene");
        }
    }
}
