using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinControls : MonoBehaviour
{
    public GameObject trashPrefab; //this item is shot out of bin
    public float minInterval = 1f; //minimum time between each shot
    public float maxInterval = 3f; //maximum time between each shot
    public bool gameOver = false;
    private float nextShootTime;

    // Start is called before the first frame update
    void Start()
    {
        //set intial shoot time
        nextShootTime = Time.time + Random.Range(minInterval, maxInterval);
    }

    // Update is called once per frame
    void Update()
    {
      if(Time.time >= nextShootTime)
        {
            // Shoot item
            ShootItem();

            //set the next shoot time
            nextShootTime = Time.time + Random.Range(minInterval, maxInterval);
        }
    }
     void ShootItem()
    {
        // Instantiate the item at the shooter's position
        Instantiate(trashPrefab, transform.position, Quaternion.identity);
    }

}
