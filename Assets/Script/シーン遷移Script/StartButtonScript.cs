﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickStartButton()
    {
        QuickRanking.Instance.SaveRanking(PlayerPrefs.GetString("UserName"), PlayerPrefs.GetInt("Weekly"));

        SceneManager.LoadScene("HomeScene");
    }
}
