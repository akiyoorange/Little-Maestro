using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ErhythmSceneScript : MonoBehaviour
{
    public GameObject NotesShortagePanel;
    
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
        if (PlayerPrefs.GetInt("Notes") >= 1)
        {
            SceneManager.LoadScene("EasyRhythmScene");

            PlayerPrefs.SetInt("Notes", PlayerPrefs.GetInt("Notes") - 1);
        }
        else
        {
            NotesShortagePanel.SetActive(true);
        }
        
    }
}
