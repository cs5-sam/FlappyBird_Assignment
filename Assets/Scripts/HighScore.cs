using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private int highScore;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Score.score + " " + highScore);
        if (Score.score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        highScoreText.text = highScore.ToString();
    }
}
