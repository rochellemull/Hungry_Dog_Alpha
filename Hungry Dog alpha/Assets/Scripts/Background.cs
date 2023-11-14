using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 start;
    private float repeat;
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
        moveBackground(repeat);
        
    }
    public void moveBackground(float repeat)
    {
        
        if (transform.position.x < (start.x - repeat))
        {
            transform.position = start;
        }
    }
}
