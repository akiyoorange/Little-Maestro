using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript: MonoBehaviour
{
    public GameObject RightPanel;
    public GameObject WrongPanel;

    public void OnClickStartButton()
    {
        if (true)
        {
            RightPanel.SetActive(true);
        }
        else
        {
            WrongPanel.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
