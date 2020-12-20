using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class hero : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    private int score = 0;
    public Text count;
    public Button Again;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //
        count.text = "Press SPACE to start";
        //count.alignment = TextAnchor.UpperLeft;
        //score.ToString();
        //
        //Again = GetComponent<Button>();
        //Again = Again.GetComponent<Button>();
        Again.enabled = true;
        rb.gravityScale = 0f; // Modified
        Again.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = 3f; // Modified
            //FlyUp(); == rb.AddForce(Vector2.up*20, mode: ForceMode2D.Impulse);
            //FlyUp();
            rb.AddForce(Vector2.up*force, mode: ForceMode2D.Impulse);
            if (!GameObject. Find("bird"))
            {
                SceneManager.LoadScene("Game");
            }
            if (count.text == "Press SPACE to start") count.text = "0";
            
        }
        if (rb.velocity.y >= 0)
        {
            //rb.transform.RotateAround(rb.transform.position, rb.transform, 60);
            
            
            transform.rotation= Quaternion.Euler(0f, 0f, 10);


        
        }
        else 
        {
            transform.rotation= Quaternion.Euler(0f, 0f, -10);
        }
        
        
    }

    void TaskOnClick(){
		Debug.Log ("Menu");
        SceneManager.LoadScene("Menu");
	}

    void FlyUp()
    {
        rb.AddForce (transform.up * force, ForceMode2D.Impulse);
    }
    /*private void OnColLisionEnter2D (Collision2D other)
    {
        Debug.Log(message: "You lost!");
        Destroy(gameObject);
    }*/
    IEnumerator waiter()
    {
        //Wait for 1 second
        yield return new WaitForSecondsRealtime(1);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Again.enabled = true;
        //if (other != )
        Debug.Log(message: "Game Over!");
        count.text = "Game Over!\nScore: " + score.ToString() + "\n\nPress SPACE to restart";
        Destroy(gameObject);
        if (score > PlayerPrefs.GetInt("record"))
            PlayerPrefs.SetInt("record", score);
        else
            PlayerPrefs.SetInt("record", PlayerPrefs.GetInt("record"));
        

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        score ++;
        count.text = score.ToString();
        Debug.Log(score);
    }
}
