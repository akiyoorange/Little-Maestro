using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question_EReading : MonoBehaviour
{
    //Image取得・表示に関して
    //Imageコンポーネントの変数
    private Image m_Image;
    //m_Imageに入れる問題spriteの変数
    public Sprite[] m_Sprite;
    //正解と不正解のPanelの変数
    public GameObject RightPanel;
    public GameObject WrongPanel;


    //判定に関して
    //ユーザーがどのボタンを押したか取得するためにAnswersystemを取得
    GameObject Answersystem;
    AnswerSystemScript Answersystemscript;
    //回答の判定を入れる変数を初期化
    public string Answer = null;
    //答えを入れる変数の初期化
    private int RightNumber = 0;


    //スコアなど
    //スコアの変数の初期化
    public int Score;


    //制限時間終了後に関して
    //カウントが0になったかの判定のためにTimerControllerスクリプトを取得
    GameObject CountdownSystem;
    TimerController Timescript;
    //終了時のパネル
    public GameObject FinishPanel;


    //クイズ中に問題を変えたり判定をしないようにするフラグ
    bool m_isInQuiz;


    // Start is called before the first frame update
    void Start()
    {
        // Imageコンポーネントを取得
        m_Image = GetComponent<Image>();
        // 1問目のスプライトをランダムに表示
        m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];


        //カウントダウンのためのCountdownSystemオブジェクトとそのスクリプトを取得
        CountdownSystem = GameObject.Find("CountdownSystem");
        Timescript = CountdownSystem.GetComponent<TimerController>();


        //ユーザー回答を取得するためAnswerSystemオブジェクトとそのスクリプトを取得
        Answersystem = GameObject.Find("AnswerSystem");
        Answersystemscript = Answersystem.GetComponent<AnswerSystemScript>();


        //1問目の正解の番号（RightNumber）を指定する関数
        GetRightNumber();


        //スコアを0点に初期化
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //クイズ中でない場合は何もしない
        if (!m_isInQuiz) return;


        //カウントダウンをする関数
        Countdown();


        //ユーザーの回答番号をAnswersystemScriptと一致させる
        int answer = Answersystemscript.AnswerNumber;


        //回答番号が0以外だった時・・・
        if (answer != 0)
        {
            if (RightNumber == answer)
            {
                Answer = "Right";　//正解番号が回答番号と等しかったらAnswerを「正解」にする
            }
            else
            {
                Answer = "Wrong";　//そうでない場合は「不正解」
            }

            m_isInQuiz = false; // 回答したらクイズ中ではない
            StartCoroutine(DelayCoroutine());   // 次の問題を読み込む
        }
    }


    //カウントダウンのための関数
    void Countdown()
    {
        //TimerControllerスクリプト内の変数「totalTime」を使用
        float totaltime = Timescript.totalTime;

        //もし残り時間が0になったらFinishパネルを表示
        if (totaltime == 0)
        {
            FinishPanel.SetActive(true);
        }
    }

    //正誤判定のための関数
    public IEnumerator DelayCoroutine()
    {
        //ユーザーの回答番号をAnswersystemScriptと一致させる
        int AnswerNumber = Answersystemscript.AnswerNumber;


        //正解時の制御
        if (Answer == "Right")
        {
            //正解パネルを起動
            RightPanel.SetActive(true);
            //スコア加算
            Score += 5;


            // 0.2秒間待つ
            yield return new WaitForSeconds(0.2f);


            //ユーザーの回答番号を0に戻す
            AnswerNumber = 0;
            //正誤判定結果を空白に戻す
            Answer = null;
            //正解パネルを隠す
            RightPanel.SetActive(false);


            //次の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
            //次の正解番号を取得
            GetRightNumber();

        }
        //不正解時の制御
        else if (Answer == "Wrong")
        {
            //不正解パネルを起動
            WrongPanel.SetActive(true);


            // 0.2秒間待つ
            yield return new WaitForSeconds(0.2f);

            //ユーザーの回答番号を0に戻す
            AnswerNumber = 0;
            //正誤判定結果を空白に戻す
            Answer = null;
            //不正解パネルを隠す
            WrongPanel.SetActive(false);


            //次の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
            //次の正解番号を取得
            GetRightNumber();
        }
    }

    //正解番号を取得する関数
    void GetRightNumber()
    {
        if (m_Image.sprite == m_Sprite[0] || m_Image.sprite == m_Sprite[2] || m_Image.sprite == m_Sprite[4] || m_Image.sprite == m_Sprite[7]
            || m_Image.sprite == m_Sprite[9] || m_Image.sprite == m_Sprite[22] || m_Image.sprite == m_Sprite[24] || m_Image.sprite == m_Sprite[27] || m_Image.sprite == m_Sprite[29] 
            || m_Image.sprite == m_Sprite[30] || m_Image.sprite == m_Sprite[33] || m_Image.sprite == m_Sprite[34] || m_Image.sprite == m_Sprite[37] || m_Image.sprite == m_Sprite[38] || m_Image.sprite == m_Sprite[41])
        {
            RightNumber = 1;
        }
        else if (m_Image.sprite == m_Sprite[12] || m_Image.sprite == m_Sprite[10] || m_Image.sprite == m_Sprite[15] || m_Image.sprite == m_Sprite[17] || m_Image.sprite == m_Sprite[19]
             || m_Image.sprite == m_Sprite[21] || m_Image.sprite == m_Sprite[36])
        {
            RightNumber = 2;
        }
        else if (m_Image.sprite == m_Sprite[1] || m_Image.sprite == m_Sprite[5] || m_Image.sprite == m_Sprite[14]
            || m_Image.sprite == m_Sprite[16] || m_Image.sprite == m_Sprite[26] || m_Image.sprite == m_Sprite[28] || m_Image.sprite == m_Sprite[31] || m_Image.sprite == m_Sprite[32]
             || m_Image.sprite == m_Sprite[35] || m_Image.sprite == m_Sprite[3])
        {
            RightNumber = 3;
        }
        else if (m_Image.sprite == m_Sprite[6] || m_Image.sprite == m_Sprite[8] || m_Image.sprite == m_Sprite[11] || m_Image.sprite == m_Sprite[13] || m_Image.sprite == m_Sprite[18]
             || m_Image.sprite == m_Sprite[20] || m_Image.sprite == m_Sprite[23] || m_Image.sprite == m_Sprite[25] || m_Image.sprite == m_Sprite[39] || m_Image.sprite == m_Sprite[40]
              )
        {
            RightNumber = 4;
        }

        m_isInQuiz = true;  // 問題の読み込みが終わったらクイズ中のステータスに入る
    }
}
