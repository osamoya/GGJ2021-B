using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credit : MonoBehaviour
{
    private int delay;
    // Start is called before the first frame update
    void Start()
    {
        delay = 60;
    }

    // Update is called once per frame
    void Update()
    {
        delay--;
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            if(delay<0)SceneManager.LoadScene("TitleScene");
        }
    }
}
