using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public AudioSource sound;
    AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    void Update()
    {
       // Debug.Log("R:" + gMScript.backR + " G:" + gMScript.backG + " B:" + gMScript.backB);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RSwitch")
        {
            if (gMScript.backR) { gMScript.backR = false; } else { gMScript.backR = true; }
            sound.PlayOneShot(sound.clip);

        }

        if (collision.gameObject.tag == "GSwitch")
        {
            if (gMScript.backG) { gMScript.backG = false; } else { gMScript.backG = true; }
            sound.PlayOneShot(sound.clip);
        }

        if (collision.gameObject.tag == "BSwitch")
        {
            if (gMScript.backB) { gMScript.backB = false; } else { gMScript.backB = true; }
            sound.PlayOneShot(sound.clip);
        }
    }

}

