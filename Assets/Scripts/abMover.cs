using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abMover : MonoBehaviour
{
    public GameObject posGO;//移動先の座標を取得するためのオブジェクト(enptyでOK)
    private Vector2 pos;//posGOのposition情報
    private float dist;//結局使わなかった初期地点と折り返し地点の最短距離
    private float Xdist;//初期地点と折り返し地点のX距離
    private float Ydist;//初期地点と折り返し地点のY距離
    private int timer;//移動中常にプラスする変数
    public int maxTime;//片道にかかるtick
    private float startX;//初期座標Xを格納(初期地点の座標として使うため)
    private float startY;//初期座標Yを格納(初期地点の座標として使うため)
    private bool toggle;//往路か復路かを格納
    private float startSX;//自分自身のサイズXを格納
    private float startSY;//自分自身のサイズYを格納
    public bool flip;//これをtrueにすることで右向きのキャラクターも進行方向を向く…はず
    // Start is called before the first frame update
    void Start()
    {
        startX = this.transform.position.x;
        startY = this.transform.position.y;
        startSX = this.transform.localScale.x;
        startSY = this.transform.localScale.y;
        pos = posGO.transform.position;
        dist = Mathf.Sqrt(Mathf.Pow(pos.x - startX, 2) + Mathf.Pow(pos.y - startY, 2));
        Xdist = startX - pos.x;
        Ydist = startY - pos.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle == false)
        {
            if (flip == true) this.transform.localScale = new Vector2(startSX, startSY);
            if (flip == false) this.transform.localScale = new Vector2(-startSX, startSY);
            this.transform.position = new Vector2(pos.x - startX + (Xdist / maxTime) * timer + startX, pos.y - startY + (Ydist / maxTime) * timer + startY);
        }
        if (toggle == true)
        {
            if (flip == true) this.transform.localScale = new Vector2(-startSX, startSY);
            if (flip == false) this.transform.localScale = new Vector2(startSX, startSY);
            this.transform.position = new Vector2(pos.x - startX + (Xdist / maxTime) * (maxTime - timer) + startX, pos.y - startY + (Ydist / maxTime) * (maxTime - timer) + startY);
        }
        timer++;
        if (maxTime <= timer && toggle == false) { timer = 0; toggle = true; }
        if (maxTime <= timer && toggle == true) { timer = 0; toggle = false; }
    }
}
