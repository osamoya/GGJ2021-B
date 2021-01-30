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
    // Start is called before the first frame update
    void Start()
    {
        goalPanel.SetActive(false);
        gameoverPanel.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        if (gMscript.gameResult = 1)
        {
            goalPanel.SetActive(true);//ゴールした際のパネル
           
        }
        else if (gMscript.gameResult = -1)
        {
            gameoverPanel.SetActive(true);//クリアした際のパネル
           
        }
        
    }
    public void Button(Button button)
    {// 引数を Button 型に設定
        if (button == nextStageButton)
        {
            SceneManager.LoadScene("SampleScene");
            gMscript.gameResult = 0;
        }
        else
        {
            Scene loadScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadScene.name);
            gMscript.gameResult = 0;
        }
    }
}

