using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeLoop : MonoBehaviour
{
    public float timeWait = 4;
    public float timer;
    public GameObject pipe;
    public float height; // 1.4

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {

        // notes
        // instantiate used for creating clone of game object
        // prefab is a component that allows full configured gameobjects to be saved in the project for reuse

        if (timer > timeWait) {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
