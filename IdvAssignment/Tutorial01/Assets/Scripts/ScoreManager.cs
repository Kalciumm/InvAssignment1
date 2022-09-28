using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    Text highscoreText;
    int score = 0;
    int highScore = 0;

    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Start()
    {
       
    }
    void Update()
    {
        scoreText.text = score.ToString() + " Points";
        highscoreText.text = "Highscore: " + highScore.ToString();
    }
     

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        Debug.Log(score);
    }
}
