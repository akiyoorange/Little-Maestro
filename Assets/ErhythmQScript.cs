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

    //正解と不正解のPanel
    public GameObject RightPanel;
    public GameObject WrongPanel;

    // Start is called before the first frame update
    void Start()
    {
        // Imageコンポーネントを取得して変数 m_Image に格納
        m_Image = GetComponent<Image>();

        // 一問目のスプライトをランダムに表示
        //　m_Sprite[]に格納した問題のスプライトをRandomで割り当て）
        m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
    }

    // Update is called once per frame
    void Update()
    {
        
        
      
    }

    // 左上
    public void Button_1()
    {
        if (m_Image.sprite = m_Sprite[1|2|6])
        {
            //正解
            RightPanel.SetActive(true);
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
        }
        else
        {
            //不正解
            WrongPanel.SetActive(true);
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0,m_Sprite.Length - 1)];
        }
    }

    // 右上
    public void Button_2()
    {
        if (m_Image.sprite = m_Sprite[3|5])
        {
            RightPanel.SetActive(true);
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
        }
        else
        {
            WrongPanel.SetActive(true);
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
        }
    }

    // 左下
    public void Button_3()
    {
        if (m_Image.sprite = m_Sprite[0|7|9|10])
        {
            RightPanel.SetActive(true);
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
        }
        else
        {
            WrongPanel.SetActive(true);
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
        }
    }

    // 右下
    public void Button_4()
    {
        if (m_Image.sprite = m_Sprite[4|8])
        {
            RightPanel.SetActive(true);
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
        }
        else
        {
            WrongPanel.SetActive(true);
            // 二問目以降の問題スプライトの変更
            m_Image.sprite = m_Sprite[Random.Range(0, m_Sprite.Length - 1)];
        }
    }
}
