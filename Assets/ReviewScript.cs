using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReviewScript : MonoBehaviour
{
    // Imageコンポーネントを格納する変数
    private Image m_Image;
    //m_Spriteの値はインスペクターから入れたSprite
    public Sprite[] m_Sprite;

    GameObject QuizImage;
    question_Erhythm script;

    // Start is called before the first frame update
    void Start()
    {
        QuizImage = GameObject.Find("QuizImage");
        script = QuizImage.GetComponent<question_Erhythm>();

        string Answer = script.Answer;

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
