using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HPrecoveryScript : MonoBehaviour
{
    public Text Notestext;
    public static int Notes;

    GameObject RecoveryTimeText;
    RecoveryTimeScript RecoveryTimescript;

    // Start is called before the first frame update
    void Start()
    {
        RecoveryTimeText = GameObject.Find("RecoveryTimeText");
        RecoveryTimescript = RecoveryTimeText.GetComponent<RecoveryTimeScript>();

        if (RecoveryTimeScript.MAXNotes == true)
        {
            Notes = 10;
        }
        else
        {
            Notes = PlayerPrefs.GetInt("Notes") + (RecoveryTimeScript.hour / 2);
        }
        Notestext.text = Notes.ToString()+("/10");
    }

    // Update is called once per frame
    void Update()
    {

        if (Notes == 10)
        {
            Notestext.text = "10/10";
        }
        else
        {

            PlayerPrefs.GetInt("Notes");

            Notestext.text = ((PlayerPrefs.GetInt("Notes")).ToString() + "/10");
            PlayerPrefs.Save();

            bool GetNotes = RecoveryTimescript.GetNotes;

            //カウントダウンの方で二時間経ったフラグがTrueになったら体力を増やす
            if (GetNotes == true)
            {
                PlayerPrefs.SetInt("Notes", PlayerPrefs.GetInt("Notes") + 1);
                Notestext.text = ((PlayerPrefs.GetInt("Notes")).ToString() + "/10");
            }
        }
        PlayerPrefs.Save();

    }
}
