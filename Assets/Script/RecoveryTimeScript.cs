using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecoveryTimeScript : MonoBehaviour
{
    public Text RecoveryTimeText;
    public int minute;
    public int hour;
    public float second;

   

    [SerializeField]public bool GetNotes;

    // Use this for initialization
    void Start()
    {
        RecoveryTimeText = GetComponent<Text>();
        GetNotes = false;
    }

    // Update is called once per frame
    void Update()
    {

        GetNotes = false;

        

        //インした時間ーログアウトした時間

        second -= Time.deltaTime;

        if (hour <= 0 && minute <= 0 && second <= 0)
        {
            hour = 2;
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
            minute -= 1;
            second = 0;
        }

        RecoveryTimeText.text = "-" + hour.ToString() + ":" + minute.ToString("00");

        if(hour == 0 && minute ==0)
        {
            GetNotes = true;
        }
    }
}



