using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;
    public float frequency;
    private bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Spawner());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !started)
        {
            started = true;
            StartCoroutine(Spawner());
        }
    }

    // Update is called once per frame
    IEnumerator Spawner()
    {
        /*while(!started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                started = true;
            }
        }*/
        while(true)
        {   
            /*if(started == true)
            {
                */yield return new WaitForSeconds(frequency);
                float rand = Random.Range(-1.3f,2f);
                GameObject newPipes = Instantiate(Pipes, new Vector3(12, rand, 0), Quaternion.identity);
                Destroy (newPipes, 5);
                /*if (GameObject. Find("bird") == null)
                    break;*/
                /*
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space))
                    started = true;
            }*/
            
        }
    }
}
