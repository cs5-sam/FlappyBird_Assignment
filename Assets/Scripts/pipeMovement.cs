using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; // completion time in seconds since the last frame
        /*if (transform.position.x <= x && !check) {
            count++;
            checked = true;
        }*/
    }
}
