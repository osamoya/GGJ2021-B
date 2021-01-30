using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightChange : MonoBehaviour
{
    public GameObject redLight;
    public GameObject greenLight;
    public GameObject blueLight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        redLight.SetActive(gMScript.backR);
        greenLight.SetActive(gMScript.backG);
        blueLight.SetActive(gMScript.backB);
    }
}
