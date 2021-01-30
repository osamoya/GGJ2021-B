using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resultController : MonoBehaviour
{
    [SerializeField]  GameObject gameoverPanel;
    [SerializeField]  GameObject goalPanel;
    [SerializeField] GameObject nextStageButton;
    [SerializeField] GameObject restartButton;
    [SerializeField] GameObject backTitleButton;
    // Start is called before the first frame update
    void Start()
    {
        goalPanel.SetActive(false);
        gameoverPanel.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        if (gMScript.gameResult == -1)
        {
            goalPanel.SetActive(true);//ゴールした際のパネル
            if(Input.GetKeyDown("Space")) {
                SceneManager.LoadScene("SampleScene");
                gMScript.gameResult = 0;

            }

        }
        else if (gMScript.gameResult == 1)
        {
            gameoverPanel.SetActive(true);//ゲームオーバーの際のパネル
            if(Input.GetKeyDown("space")) {
                Scene loadScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(loadScene.name);
                gMScript.gameResult = 0;

            }
            else if (Input.GetKeyDown("escape"))
            {
                SceneManager.LoadScene("TitleScene");
                gMScript.gameResult = 0;

            }


        }
        
    }
    public void Button(Button button)
    {// 引数を Button 型に設定
        if (button == nextStageButton)
        {
            SceneManager.LoadScene("SampleScene");
            gMScript.gameResult = 0;
        }
        else if (button == restartButton)
        {
            Scene loadScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadScene.name);
            gMScript.gameResult = 0;
        }
        else{
           SceneManager.LoadScene("TitleScene");
                gMScript.gameResult = 0;
        }
    }
}

