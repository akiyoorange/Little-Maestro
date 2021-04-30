using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyWeeklyScoreScript : MonoBehaviour
{
    public Text MyWeeklyScoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int MyWeeklyScore = WeeklyScoreController.WeeklyScore;

        //表示
        MyWeeklyScoreText.text = PlayerPrefs.GetInt("Weekly").ToString();
        PlayerPrefs.Save();
    }
}
