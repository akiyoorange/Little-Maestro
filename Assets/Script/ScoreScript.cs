using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject score_object;

    GameObject QuizImage;
    question_Erhythm script;

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

        // オブジェクトからTextコンポーネントを取得
        Text scoreText = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        scoreText.text = Score.ToString();
    }
}
