using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start() { 
    
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        //GetComponent<UnityEngine.UI.Text>().text = score.ToString();

    }
}
