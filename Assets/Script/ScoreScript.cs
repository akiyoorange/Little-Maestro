using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject score_object;
    public GameObject weeklyscore_object;

    GameObject QuizImage;
    question_Erhythm script;

    bool isCalledOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        QuizImage = GameObject.Find("QuizImage");
        script = QuizImage.GetComponent<question_Erhythm>();
    }

    // Update is called once per frame
    void Update()
    {
        int Score = script.Score;

        int WeeklyScore = WeeklyScoreController.WeeklyScore;

        // オブジェクトからTextコンポーネントを取得
        Text scoreText = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        scoreText.text = Score.ToString();

        //HomeSceneのWeeklyScoreControllerから現在のWeeklyScoreを取得
        Text WeeklyScoreText = weeklyscore_object.GetComponent<Text>();

        if (!isCalledOnce)
        {
            isCalledOnce = true;
            //ゲーム前のWeeklyScoreにScoreを足す
            PlayerPrefs.SetInt("Weekly", PlayerPrefs.GetInt("Weekly") + Score);
        }

        

        //表示
        WeeklyScoreText.text = PlayerPrefs.GetInt("Weekly").ToString();
        PlayerPrefs.Save();

       
    }
}
