using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextScoreScript : MonoBehaviour
{
    //Image取得・表示に関して
    //Imageコンポーネントの変数
    public Text NextScoreText;
    //ScoreImageに入れる問題spriteの変数
  

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Weekly") <= 1999)
        {
            NextScoreText.text = "2000";
        }
        else if (PlayerPrefs.GetInt("Weekly") <= 4999 && PlayerPrefs.GetInt("Weekly") >= 2000)
        {
            
        }
        else if (PlayerPrefs.GetInt("Weekly") <= 9999 && PlayerPrefs.GetInt("Weekly") >= 5000)
        {
            
        }
        else if (PlayerPrefs.GetInt("Weekly") <= 19999 && PlayerPrefs.GetInt("Weekly") >= 10000)
        {
            
        }
        else if (PlayerPrefs.GetInt("Weekly") <= 29999 && PlayerPrefs.GetInt("Weekly") >= 20000)
        {
        
        }
        else if (PlayerPrefs.GetInt("Weekly") >= 30000)
        {
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
