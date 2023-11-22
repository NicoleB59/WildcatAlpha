using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //private Vector3 startP;
    //private float repeatW;

    public float speed;
    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        //startP = transform.position; //Default start position
        //repeatW = GetComponent<BoxCollider>().size.x / 2; //repeat width
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if background moves left by its repeat width move it back to the starting pos
        //if(transform.position.x < startP.x - repeatW) 
        //{
            //transform.position = startP;
        //}
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.y < -250f)
        {
            transform.position = StartPosition;
        }
    }
}
