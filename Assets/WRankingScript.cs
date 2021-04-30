using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WRankingScript : MonoBehaviour
{
    public Text WorldRankingtext;
    public Text playerCounter;

    // Start is called before the first frame update
    void Start()
    {
        WorldRankingtext.text = QuickRanking.Instance.GetRankingByText();

        QuickRanking.Instance.FetchPlayerCount(SetPlayerCounter);
    }

    void SetPlayerCounter()
    {
        WorldRankingtext.text = PlayerPrefs.GetInt("Weekly") + QuickRanking.Instance.PlayerCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
