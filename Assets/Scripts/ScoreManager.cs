using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public int highscore;
    public PlayerMove player;

    // Use this for initialization
    void Start()
    {
        scoreText.text = "Score: 0";
        highscore = PlayerPrefs.GetInt("Highscore",0);
        player = FindObjectOfType<PlayerMove>();
        Debug.Log("START: highscore = " + highscore);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isDead)
        {
            if (highscore < score)
            {
                saveHighScore(score);
            }
        }
    }

    public void addToScore()
    {
        score += 10;
        Debug.Log("Score: " + score);
        scoreText.text = "Score: " + score.ToString();
    }

    // updates the stored highscore to be the current player score
    public void saveHighScore(int score) //string name)
    {
        highscore = score;
        PlayerPrefs.SetInt("Highscore", highscore);
        Debug.Log("Score saved! Highscore is: " + highscore);
    }
}
