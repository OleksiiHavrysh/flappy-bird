using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    
    public Button start;
    public Button settings;
    public Button exit;
    // Start is called before the first frame update
    void Start()
    {
        /*start = GetComponent<Button>();
        settings = GetComponent<Button>();
        quit = GetComponent<Button>();*/

        start.enabled = true;
        settings.enabled = true;
        exit.enabled = true;

        start.onClick.AddListener(TaskOnClickStart);
        settings.onClick.AddListener(TaskOnClickSettings);
        exit.onClick.AddListener(TaskOnClickExit);
    }
    void GoToMain()
    {
	    SceneManager.LoadScene("Game"); //Переход на сцену с названием Menu
    }
    void TaskOnClickStart(){
		Debug.Log ("Start");
        GoToMain();
	}
    void TaskOnClickSettings(){
		Debug.Log ("Settings");
        SceneManager.LoadScene("Settings");
	}
    void TaskOnClickExit(){
		Debug.Log ("Exit");
        Application.Quit();
	}
}
