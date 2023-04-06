using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{ public bool enableSpawn = false;
    public GameObject Box;
    void SpawnBox()
    {
        float randomX = Random.Range(-5f, 5f);
        if (enableSpawn)
        {
            GameObject box = (GameObject)Instantiate(Box, new Vector3(randomX, 1.1f, 0f), Quaternion.identity);
        }
        float randomY = Random.Range(-5f, 5f);
        if (enableSpawn)
        {
            GameObject box = (GameObject)Instantiate(Box, new Vector3(randomY, 1.1f, 0f), Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBox", 3, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
