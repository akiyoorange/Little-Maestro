using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyButtonScript : MonoBehaviour
{
    public GameObject EasyPanel;

    public void OnClickStartButton()
    {
        EasyPanel.SetActive(true);
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
