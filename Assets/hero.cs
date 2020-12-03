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
    private int score;
    public Text count;
    public Button Again;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //
        score = 0;
        count.text = score.ToString();
        //
        //Again = GetComponent<Button>();
        Again.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //FlyUp(); == rb.AddForce(Vector2.up*20, mode: ForceMode2D.Impulse);
            //FlyUp();
            rb.AddForce(Vector2.up*force, mode: ForceMode2D.Impulse);
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
        /*if (Again.())
        {
            SceneManager.LoadScene(0);
        }*/
        
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
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Again.enabled = true;
        //if (other != )
        Debug.Log(message: "You lost!");
        count.text = "You lost!\nScore: " + score.ToString();
        Destroy(gameObject);
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        score ++;
        count.text = score.ToString();
        Debug.Log(score);
    }
}
