using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreImageControllerHome : MonoBehaviour
{
    //Image取得・表示に関して
    //Imageコンポーネントの変数
    private Image ScoreImage;
    //ScoreImageに入れる問題spriteの変数
    public Sprite[] m_Sprite;

    // Start is called before the first frame update
    void Start()
    {
        // Imageコンポーネントを取得
        ScoreImage = GetComponent<Image>();

        if (PlayerPrefs.GetInt("Weekly") <= 1999)
        {
            ScoreImage.sprite = m_Sprite[0];
        }
        else if (PlayerPrefs.GetInt("Weekly") <= 4999 && PlayerPrefs.GetInt("Weekly") >= 2000)
        {
            ScoreImage.sprite = m_Sprite[1];
        }
        else if (PlayerPrefs.GetInt("Weekly") <= 9999 && PlayerPrefs.GetInt("Weekly") >= 5000)
        {
            ScoreImage.sprite = m_Sprite[2];
        }
        else if (PlayerPrefs.GetInt("Weekly") <= 19999 && PlayerPrefs.GetInt("Weekly") >= 10000)
        {
            ScoreImage.sprite = m_Sprite[3];
        }
        else if (PlayerPrefs.GetInt("Weekly") <= 29999 && PlayerPrefs.GetInt("Weekly") >= 20000)
        {
            ScoreImage.sprite = m_Sprite[4];
        }
        else if (PlayerPrefs.GetInt("Weekly") >= 30000)
        {
            ScoreImage.sprite = m_Sprite[5];
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
