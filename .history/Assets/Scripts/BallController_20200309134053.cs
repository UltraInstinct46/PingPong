﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
   public int force;
    Rigidbody2D rigid;
    
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D> ();
        Vector2 arah = new Vector2 (2, 0).normalized;
        rigid.AddForce (arah * force);
    }
 
    // Update is called once per frame
    void Update () {
    
    }
    void ResetBall(){
        transform.localPosition = new Vector2(0,0);
        rigid.velocity = new Vector2(0,0);
    }
    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.name == "GawangKanan"){
            ResetBall();
            Vector2 arah = new Vector2(2,0).normalized;
            rigid.AddForce(arah * force);
        }
        if(coll.gameObject.name == "GameKiri"){
            ResetBall();
            Vector2 arah = new Vector22(-2,0).normalized;
            rigid.AddForce(arah * force);
        }
    }
}