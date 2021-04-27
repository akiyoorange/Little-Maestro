using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question_Erhythm : MonoBehaviour
{

    // Imageコンポーネントを格納する変数
    private Image m_Image;
    //m_Spriteの値はインスペクターから入れたSprite
    public Sprite[] m_Sprite;

    //正解と不正解のPanel
    public GameObject RightPanel;
    public GameObject WrongPanel;

    //Answersystemのオブジェクトとスクリプト
    GameObject Answersystem;
    AnswerSystemScript Answersystemscript;

    //回答の判定を入れる変数
    public string Answer　= null;

    //正解の番号を入れる変数の初期化
    private int RightNumber = 0;

    //スコア計算のための変数の初期化
    public int Score = 0;
    bool isCalledOnce = false;

    //カウントが0になったかの判定のためにTimerControllerスクリプトを取得
    GameObject CountdownSystem;
    TimerController Timescript;

    //終了時のパネル
    public GameObject FinishPanel;

    // Start is called before the first frame update
    void Start()
    {
        // Imageコンポーネントを取得して変数 m_Image に格納
        m_Image = GetComponent<Image>();

        // 一問目のスプライトをランダムに表示
        m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];

        //CountdownSystemオブジェクトとそのScriptを取得
        CountdownSystem = GameObject.Find("CountdownSystem");
        Timescript = CountdownSystem.GetComponent<TimerController>();

        //正解の番号（RightNumber）を指定
        GetRightNumber();

        //回答結果を取得
        Answersystem = GameObject.Find("AnswerSystem");
        Answersystemscript = Answersystem.GetComponent<AnswerSystemScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Countdown();

        //回答された番号をAnswersystemScriptと一致させる
        int AnswerNumber = Answersystemscript.AnswerNumber;

        //RightNumberがAnswerNumberと等しかった時に正解にする
        if (RightNumber == AnswerNumber)
        {
            Answer = "Right";
        }
        else if (RightNumber != AnswerNumber && AnswerNumber != 0)
        {
            Answer = "Wrong";
        }

        StartCoroutine(DelayCoroutine());
    }


    void Countdown()
    {
        //TimerControllerスクリプト内の変数「totalTime」を使用
        float totaltime = Timescript.totalTime;

        //もしCountdownが0になったら結果のパネルを表示
        if (totaltime == 0)
        {
            //Finishパネル表示
            FinishPanel.SetActive(true);
        }
    }

     public IEnumerator DelayCoroutine()
     {
        int AnswerNumber = Answersystemscript.AnswerNumber;

        //RかWに応じてパネルの表示とスコア加算
        if (Answer == "Right")
        {
            RightPanel.SetActive(true);
            if (!isCalledOnce)
            {
                isCalledOnce = true;
                Score = +5;
            }
            AnswerNumber = 0;
            
            // 1秒間待つ
            yield return new WaitForSeconds(0.3f);
            Answer = null;
            RightPanel.SetActive(false); 
          
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
            GetRightNumber();

        }
        else if (Answer == "Wrong")
        {
            WrongPanel.SetActive(true);
            AnswerNumber = 0;
           
            // 1秒間待つ
            yield return new WaitForSeconds(0.3f);
            Answer = null;
            WrongPanel.SetActive(false);

            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];

            GetRightNumber();
        }   

        

     }

    void GetRightNumber()
    {
        //正解の番号（RightNumber）を指定
        if (m_Image.sprite == m_Sprite[1] || m_Image.sprite == m_Sprite[2] || m_Image.sprite == m_Sprite[5])
        {
            RightNumber = 1;
        }
        else if (m_Image.sprite == m_Sprite[3] || m_Image.sprite == m_Sprite[4] || m_Image.sprite == m_Sprite[9])
        {
            RightNumber = 2;
        }
        else if (m_Image.sprite == m_Sprite[0] || m_Image.sprite == m_Sprite[6] || m_Image.sprite == m_Sprite[8])
        {
            RightNumber = 3;
        }
        else if (m_Image.sprite == m_Sprite[7])
        {
            RightNumber = 4;
        }
    }

}
