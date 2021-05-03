using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ApplicationController : MonoBehaviour
{
    DateTime today = DateTime.Today;
    DateTime now = DateTime.Now;

    public static string outticks;

    public static long INTicks;

    // アプリケーションが終了する前に呼び出し
    public void OnApplicationQuit()
    {
        //ログアウト時間をタイマ刻み数で取得する
        long OUTTicks = DateTime.Now.Ticks;

        //longを文字変換
        string outticks = OUTTicks.ToString();
        //デバイスに保存
        PlayerPrefs.SetString("OUTTicks", outticks) ;
        PlayerPrefs.Save();

    }

    //アプリケーションの起動時に呼び出し
    public void Awake()
    {
       //ログイン時間をタイマ刻み数で取得する
        long INTicks = DateTime.Now.Ticks;
    }

    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}