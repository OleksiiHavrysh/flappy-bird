using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RecordsScript : MonoBehaviour
{
    public Text recordtext;
    private int record = 0;
    public Button menu;
    
    // Start is called before the first frame update
    void TaskOnClickMenu(){
        SceneManager.LoadScene("Menu");
	}
    void Start()
    {
        menu.enabled = true;
        menu.onClick.AddListener(TaskOnClickMenu);
        if (!PlayerPrefs.HasKey("record"))
        {
            PlayerPrefs.SetInt("record", 0);
        }
        else{
            record = PlayerPrefs.GetInt("record");
        }
        recordtext.text = "Record: " + record.ToString();
    }

    // Update is called once per frame
    
}
