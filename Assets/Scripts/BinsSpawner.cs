using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinsSpawner : MonoBehaviour
{
    public GameObject[] binPrefabs;
    private float spawnRangeX = 209f;
    private float spawnPosZ = -7.9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.D))
        {
            //Randomly generate Trash
            Vector3 spawnRos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosZ);
            int binIndex = Random.Range(0, binPrefabs.Length);
            Instantiate(binPrefabs[binIndex], new Vector3(209, 7.9f, -7.9f), binPrefabs[binIndex].transform.rotation);
        }  
    }
}
