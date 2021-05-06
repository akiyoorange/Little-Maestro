using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RecoveryTimeScript : MonoBehaviour
{
    public Text RecoveryTimeText;
    public int minute;
    public static int hour;
    public float second;

    int SleepDays;
    int SleepHours;
    int SleepMinutes;
    int SleepSeconds;

    [SerializeField] public bool GetNotes;

    public static bool MAXNotes = false;

    void HPrecovery()
    {
        //前回のログアウト時間を取得
        PlayerPrefs.GetString("OUTTicks");
        long OUTticks = long.Parse(PlayerPrefs.GetString("OUTTicks"));

        //今回のログイン時間を取得
        long INticks = ApplicationController.INTicks;

        //今回のログイン時間からログアウト時間を引き、差を求める
        long Sleepticks = INticks - OUTticks;

        //タイムスパン型に変換
        TimeSpan SleepTime = new TimeSpan(Sleepticks);

        //日・時・分・秒に変換
        SleepDays = (int)SleepTime.Days;
        SleepHours = (int)SleepTime.Hours;
        SleepMinutes = (int)SleepTime.Minutes;
        SleepSeconds = (int)SleepTime.Seconds;
        Debug.Log("前回のログアウトから" + SleepDays + "日" + SleepHours + ":" + SleepMinutes + ":" + SleepSeconds + "経過しました。");

        if (SleepDays != 0)
        {
            MAXNotes = true;
        }
        else if (SleepDays == 0 && SleepHours != 1 && SleepHours != 0)
        {
            MAXNotes = true;
        }
        else
        {
            MAXNotes = false;
        }

        if (MAXNotes == false)
        {
            hour = SleepHours;
            minute = SleepMinutes;
            second = SleepSeconds;
        }

    }

    // Use this for initialization
    void Start()
    {
        HPrecovery();

        RecoveryTimeText = GetComponent<Text>();
        GetNotes = false;

    }

    // Update is called once per frame
    void Update()
    {

        GetNotes = false;

        second -= Time.deltaTime;

        //Notesが10じゃない時に2時間カウントダウンを繰り返す
        if (MAXNotes == false)
        {

            if (hour <= 0 && minute <= 0 && second <= 0)
            {
                hour = 2;
                GetNotes = true;
            }
            else if (hour == 2 && minute == 0 && second <= 0)
            {
                hour = 1;
                minute = 59;
            }

            if (minute < 0)
            {
                hour--;
                minute = 59;
            }

            if (second < -60f)
            {
                minute--;
                second = 0;
            }

            RecoveryTimeText.text = "-" + hour.ToString() + ":" + minute.ToString("00");

        }
    }


}

