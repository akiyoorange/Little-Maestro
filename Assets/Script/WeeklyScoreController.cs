using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeeklyScoreController : MonoBehaviour
{
    public GameObject weeklyScoreText;
    public static  int WeeklyScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text WeeklyScoreText = weeklyScoreText.GetComponent<Text>();


        WeeklyScoreText.text = PlayerPrefs.GetInt("Weekly").ToString();

        PlayerPrefs.Save();
    }
}
