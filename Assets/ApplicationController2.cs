using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//ログアウト時間記録スクリプト
public class ApplicationController2 : MonoBehaviour
{
    DateTime today = DateTime.Today;
    DateTime now = DateTime.Now;

    public static string outticks;
    public static long OUTTicks;

    // アプリケーションが終了する前に呼び出し
    public void OnApplicationQuit()
    {
        //ログアウト時間をタイマ刻み数で取得する
        OUTTicks = DateTime.Now.Ticks;

        //longを文字変換
        string outticks = OUTTicks.ToString();
        //デバイスに保存
        PlayerPrefs.SetString("OUTTicks", outticks);
        PlayerPrefs.Save();

        Debug.Log("LogOUT is "+outticks);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
