using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SettingsScript : MonoBehaviour
{
    public Button menu;
    public Slider speed;
    // Start is called before the first frame update
    void Start()
    {
        menu.enabled = true;
        menu.onClick.AddListener(TaskOnClick);
        speed.value = PlayerPrefs.GetFloat("velocity");
    }
    void TaskOnClick(){
        SceneManager.LoadScene("Menu");
        PlayerPrefs.SetFloat("velocity", speed.value);
	}
    
}
