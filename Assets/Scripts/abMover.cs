using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abMover : MonoBehaviour
{
    public GameObject posGO;
    private Vector2 pos;
    private float dist;
    private float Xdist;
    private float Ydist;
    private int timer;
    public int maxTime;
    private float startX;
    private float startY;
    private bool toggle;
    // Start is called before the first frame update
    void Start()
    {
        startX =this.transform.position.x;
        startY = this.transform.position.y;
        pos = posGO.transform.position;
        dist = Mathf.Sqrt(Mathf.Pow(pos.x-startX, 2) + Mathf.Pow(pos.y-startY, 2));
        Xdist = startX - pos.x;
        Ydist = startY - pos.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle == false) this.transform.position = new Vector2(pos.x - startX + (Xdist / maxTime) * timer + startX, pos.y - startY + (Ydist / maxTime) * timer + startY);
        if (toggle == true) this.transform.position = new Vector2(pos.x - startX + (Xdist / maxTime) * (maxTime-timer) + startX, pos.y - startY + (Ydist / maxTime) * (maxTime-timer) + startY);
        timer++;
        if (maxTime <= timer && toggle == false) { timer = 0; toggle = true; }
        if (maxTime <= timer && toggle == true) { timer = 0; toggle = false; }
    }
}
