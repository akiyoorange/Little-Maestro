using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightSEController : MonoBehaviour
{
    //SEを格納
    public AudioClip RightSE;
    public AudioClip WrongSE;
　　AudioSource audioSource;

    //回答が正解か不正解かの判定をQuizImageのスクリプトから取得
    GameObject QuizImage;
    question_Erhythm script;

    // Start is called before the first frame update
    void Start()
    {
        //AudioのComponentを取得
        audioSource = GetComponent<AudioSource>();

        //QuizImageオブジェクトとそのScriptを取得
        QuizImage = GameObject.Find("QuizImage");
        script = QuizImage.GetComponent<question_Erhythm>();

    }

    // Update is called once per frame
    void Update()
    {
        //Script中の変数「SE」を「answerSE」として使用
        string answerSE = script.Answer;

        //正誤によって鳴らすSEを変える
        if (answerSE == "Right")
        {
            audioSource.PlayOneShot(RightSE);
        }
        else if(answerSE == "Wrong")
        {
            audioSource.PlayOneShot(WrongSE);
        }
    }
}
