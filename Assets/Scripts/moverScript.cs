using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverScript : MonoBehaviour
{
    //private Animator animator;
    public float speed = 1.0F;    // 移動早さ
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");//縦向き
        var v = Input.GetAxis("Vertical");
        //animator.SetBool("walk", false);
        rb.velocity = new Vector2(h * speed,v*speed);//動かすメインのスクリプト
    }
}