using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   //Declaring GameObject and new position
    public GameObject binPrefab;
    private Vector3 position = new Vector3(25, 0, 0);

    //Delcaring new var with values
    private float delay = 7;
    private float repeat = 5;

    //Referencing another script
    private PlayerControls catControls;

    // Start is called before the first frame update
    void Start()
    {
        //Repeats and spawns
        InvokeRepeating("SpawnBin", delay, repeat);
        catControls = GameObject.Find("Cat").GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //Stop spawning when gameover
    void SpawnBin()
    {
        //If it is not game over.. 
        if(catControls.gameOver == false)
        {
            Instantiate(binPrefab, position, binPrefab.transform.rotation);
        }
        
    }
}
