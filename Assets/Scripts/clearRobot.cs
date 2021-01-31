using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearRobot : MonoBehaviour
{
    private int random;
    public GameObject[] robot;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < robot.Length; i++) {
            robot[i].SetActive(false);
        }
        random = Random.Range(0, robot.Length);
    }

    // Update is called once per frame
    void Update()
    {
        robot[random].SetActive(true);
    }
}
