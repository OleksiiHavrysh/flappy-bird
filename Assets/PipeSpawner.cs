using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;
    public float frequency;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    IEnumerator Spawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(frequency);
            float rand = Random.Range(-1.3f,2f);
            GameObject newPipes = Instantiate(Pipes, new Vector3(12, rand, 0), Quaternion.identity);
            Destroy (newPipes, 5);
        }
    }
}
