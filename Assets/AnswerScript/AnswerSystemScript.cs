using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerSystemScript : MonoBehaviour
{
    public int AnswerNumber;
    
    GameObject Answer1;
    Answer1Script Script1;
    GameObject Answer2;
    Answer2Script Script2;
    GameObject Answer3;
    Answer3Script Script3;
    GameObject Answer4;
    Answer4Script Script4;

    // Start is called before the first frame update
    void Start()
    {
        Answer1 = GameObject.Find("Answer1");
        Script1 = Answer1.GetComponent<Answer1Script>();
        Answer2 = GameObject.Find("Answer2");
        Script2 = Answer2.GetComponent<Answer2Script>();
        Answer3 = GameObject.Find("Answer3");
        Script3 = Answer3.GetComponent<Answer3Script>();
        Answer4 = GameObject.Find("Answer4");
        Script4 = Answer4.GetComponent<Answer4Script>();
    }

    // Update is called once per frame
    void Update()
    {
        int Answer1 = Script1.Answer1;
        int Answer2 = Script2.Answer2;
        int Answer3 = Script3.Answer3;
        int Answer4 = Script4.Answer4;

        if (Answer1 == 1)
        {
            AnswerNumber = 1;
        }
        else if (Answer2 == 2)
        {
            AnswerNumber = 2;
        }
        else if (Answer3 == 3)
        {
            AnswerNumber = 3;
        }
        else if (Answer4 == 4)
        {
            AnswerNumber = 4;
        }
    }
}
