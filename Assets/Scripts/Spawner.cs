using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Declaring GameObject and new position
    public GameObject [] ObsPrefabs;

    //Delcaring new var with values
    private float delay = 7;
    private float repeat = 5;

    //Referencing another script
    private PlayerControls catControls;

    // Start is called before the first frame update
    void Start()
    {
        //Repeats and spawns
        InvokeRepeating("ObsSpawn" , delay, repeat);
        catControls = GameObject.Find("Cat").GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ObsSpawn()
    {
        if (catControls.gameOver == false)
        {
            int obsIndex = Random.Range(0, ObsPrefabs.Length);
            Instantiate(ObsPrefabs[obsIndex], new Vector3(25, 0, 0), ObsPrefabs[obsIndex].transform.rotation);
        }
    }
}
