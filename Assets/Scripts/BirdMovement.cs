using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    public float speed = 8;
    public float force = 150;
    private Rigidbody2D body;
    public GameManage gameManage;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            body.velocity = Vector2.up * speed; // jump
            //body.AddForce(Vector3.up * force);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManage.GameOver();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /*public void GameOver()
    {
        Time.timeScale = 0;
    }*/
}
