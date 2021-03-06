﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moverScript : MonoBehaviour
{
    private Animator animator;
    public float speed = 1.0F;    // 移動早さ
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");//縦向きの動きを
        var v = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W)) v =  1;
        if (Input.GetKey(KeyCode.S)) v = -1;
        if (Input.GetKey(KeyCode.A)) h = -1;
        if (Input.GetKey(KeyCode.D)) h =  1;
        if (Input.GetKey(KeyCode.R)) SceneManager.LoadScene("Stage" + gMScript.nowStageNum);
        if (Input.GetKey(KeyCode.T)) SceneManager.LoadScene("TitleScene");
        //Debug.Log(h);
        animator.SetBool("destroy", false);
        animator.SetBool("walk", false);
        rb.velocity = new Vector2(h * speed, v * speed);//動かすメインのスクリプト
        if (Mathf.Abs(h + v) >= 0.01&& gMScript.gameResult == 0) {
            animator.SetBool("walk", true);
        }
        if (gMScript.gameResult == 1) {
            animator.SetBool("destroy", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            gMScript.gameResult = -1;Debug.Log("ゴール");
        }
    }
}