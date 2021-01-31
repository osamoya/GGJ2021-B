using System.Collections;
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
    public AudioSource select;
    public AudioSource accept;
    AudioSource audiosource1;
    AudioSource audiosource2;
    //gMScript.nowStageNum;
    // Start is called before the first frame update
    void Start()
    {
        audiosource1 = GetComponent<AudioSource>();
        audiosource2 = GetComponent<AudioSource>();
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
            select.PlayOneShot(select.clip);
            allMapX -= 768;
            chooseMap++;
        }
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))&&chooseMap>1) {//左
            select.PlayOneShot(select.clip);
            allMapX += 768;
            chooseMap--;
        }
        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.Return))
        {
            accept.PlayOneShot(accept.clip);
            SceneManager.LoadScene("Stage"+ chooseMap);
            gMScript.nowStageNum = chooseMap;
        }
                
    }
    public void left() {
        if (chooseMap > 1)
        {//左
            select.PlayOneShot(select.clip);
            allMapX += 768;
            chooseMap--;
        }
    }
    public void right()
    {
        if (chooseMap < maxStageNum)
        {//右
            select.PlayOneShot(select.clip);
            allMapX -= 768;
            chooseMap++;
        }
    }
}
