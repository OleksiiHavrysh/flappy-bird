using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector2.left * speed * Time.deltaTime);
        //rb.velocity = new Vector2 (-speed, 0f);
        /*if (rb.transform.position < -11)
        {
            rb.transform.position = 11;
        }*/
    }

}
