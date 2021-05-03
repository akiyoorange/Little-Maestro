using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ApplicationController : MonoBehaviour
{
    //ログインした時間
    public static string datetimeIN;
    //ログアウトした時間
    public static string datetimeOUT;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //アプリケーションの起動時に呼び出し
    public void Awake()
    {
        Debug.Log("Awake");

        datetimeIN = DateTime.Now.ToShortTimeString();
        Debug.Log(datetimeIN);
    }

    // アプリケーションが終了する前に呼び出し
    public void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");

        datetimeOUT = DateTime.Now.ToShortTimeString();
        Debug.Log(datetimeOUT);
    }
}