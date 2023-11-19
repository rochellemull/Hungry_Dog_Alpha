using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 start;
    private float repeat = 3;
    // Start is called before the first frame update
    void Start()
    {
        //start = transform.position;
        start = transform.position;
        repeat = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < (start.x - repeat))
        {
            transform.position = start;
        }

    }
    public void moveBackground(float repeat)
    {
        
        
    }
}
