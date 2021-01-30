using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanegaeDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("background R"+gMScript.backR+" G"+gMScript.backG+" B"+gMScript.backB);
    }
}
