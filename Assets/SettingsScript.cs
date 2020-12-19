using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SettingsScript : MonoBehaviour
{
    public Button menu;
    // Start is called before the first frame update
    void Start()
    {
        menu.enabled = true;
        menu.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick(){
        SceneManager.LoadScene("Menu");
	}
}
