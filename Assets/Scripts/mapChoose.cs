﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapChoose : MonoBehaviour
{
    private int chooseMap=1;
    private int allMapX;
    public int maxStageNum;
    public GameObject leftAr;
    public GameObject rightAr;
    //gMScript.nowStageNum;
    // Start is called before the first frame update
    void Start()
    {
        gMScript.gameResult = 0;
    }

    // Update is called once per frame
    void Update()
    {
        leftAr.SetActive(true);
        rightAr.SetActive(true);
        if (chooseMap == 1) leftAr.SetActive(false);
        if (chooseMap == maxStageNum) rightAr.SetActive(false);
        this.transform.position = new Vector2(allMapX+960, 560);
        if ((Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow))&& chooseMap<maxStageNum) {//右
            allMapX -= 768;
            chooseMap++;
        }
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))&&chooseMap>1) {//左
            allMapX += 768;
            chooseMap--;
        }
        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Stage"+ chooseMap);
            gMScript.nowStageNum = chooseMap;
        }
                
    }
    public void left() {
        if (chooseMap > 1)
        {//左
            allMapX += 768;
            chooseMap--;
        }
    }
    public void right()
    {
        if (chooseMap < maxStageNum)
        {//右
            allMapX -= 768;
            chooseMap++;
        }
    }
}
