﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WRankingScript : MonoBehaviour
{
    public Text WorldRankingtext;

    // Start is called before the first frame update
    void Start()
    {
        WorldRankingtext.text = QuickRanking.Instance.GetRankingByText();

    }

    

    // Update is called once per frame
    void Update()
    {

    }
}
