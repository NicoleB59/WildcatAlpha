using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackGround : MonoBehaviour
{

    private Vector3 startP;
    private float repeatW;

    // Start is called before the first frame update
    void Start()
    {
        startP = transform.position;
        repeatW = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startP.x - repeatW)
        {
            transform.position = startP;
        }
    }
}
