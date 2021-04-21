using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpertButtonScript : MonoBehaviour
{
    public GameObject ExpertPanel;

    public void OnClickStartButton()
    {
        ExpertPanel.SetActive(true);
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
