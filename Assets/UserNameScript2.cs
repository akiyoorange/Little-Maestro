using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserNameScript2 : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetString("UserName");
    }

    // Update is called once per frame
    void Update()
    {
        //テキストにinputFieldの内容を反映
        text.text = PlayerPrefs.GetString("UserName");
        PlayerPrefs.Save();
    }
}
