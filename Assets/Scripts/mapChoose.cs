using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapChoose : MonoBehaviour
{
    private int chooseMap;
    private int allMapX;
    public int maxStageNum;
    //gMScript.nowStageNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(allMapX+960, 560);
        if (Input.GetKeyDown(KeyCode.RightArrow)&& chooseMap<maxStageNum-1) {//右
            allMapX -= 768;
            chooseMap++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)&&chooseMap>0) {//左
            allMapX += 768;
            chooseMap--;
        }
        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Stage"+ chooseMap+1);
            gMScript.nowStageNum = chooseMap + 1;
        }
    }
    public void left() {
        if (chooseMap > 0)
        {//左
            allMapX += 768;
            chooseMap--;
        }
    }
    public void right()
    {
        if (chooseMap < maxStageNum - 1)
        {//左
            allMapX -= 768;
            chooseMap++;
        }
    }
}
