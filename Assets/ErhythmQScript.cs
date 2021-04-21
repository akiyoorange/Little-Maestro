using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErhythmQScript : MonoBehaviour
{
   　// Imageコンポーネントを格納する変数
    private Image m_Image;
    // 問題のスプライトオブジェクトを格納する配列
    public Sprite[] m_Sprite;
  
    // Start is called before the first frame update
    void Start()
    {
        //Answer1~4のボタンを取得
        GameObject[] Answers = GameObject.FindGameObjectsWithTag("AnswerButton");

        // Imageコンポーネントを取得して変数 m_Image に格納
        m_Image = GetComponent<Image>();

        // 一問目のスプライトをランダムに表示
        //　m_Sprite[]に格納した問題のスプライトをRandomで割り当て）
        m_Image.sprite = m_Sprite[Random.Range(0, 9)];
    }

    // Update is called once per frame
    void Update()
    {
        bool answer = true;

        if (m_Image.sprite = m_Sprite[0])
        {

        }


        // スペースキーが押された場合
        if (Input.GetKeyDown(KeyCode.Space))
        {
                // 二問目以降の問題スプライトの変更
                m_Image.sprite = m_Sprite[Random.Range(0,9)];  
        }

       
    }
}
