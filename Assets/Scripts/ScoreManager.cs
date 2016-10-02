using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        scoreText.text = "Score: 0";  
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addToScore()
    {
        score += 10;
        Debug.Log("Score: " + score);
        scoreText.text = "Score: " + score.ToString();
    }
}
