using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private int highScore;
    public Text highScoreText;
    // Start is called before the first frame update
    void Awake()
    {
        //if(player)
    }
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        Debug.Log("Current Score: "+Score.score + "And Last Saved Score: " + highScore);
        if (Score.score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", Score.score);
        }
        highScoreText.text = highScore.ToString();
    }
}
