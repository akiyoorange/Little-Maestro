using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//ログイン時間記録スクリプト
public class ApplicationController : MonoBehaviour
{
    DateTime today = DateTime.Today;
    DateTime now = DateTime.Now;

    public static long INTicks;

    //アプリケーションの起動時に呼び出し
    public void Awake()
    {
       //ログイン時間をタイマ刻み数で取得する
        INTicks = DateTime.Now.Ticks;
        Debug.Log("LogIN is "+INTicks);
    }

    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}