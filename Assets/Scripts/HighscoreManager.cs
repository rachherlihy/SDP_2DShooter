using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighscoreManager : MonoBehaviour
{
    public int highscore;
    public Text highscoreText;
    
    // Use this for initialization
    void Start ()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        highscoreText.text = "Highscore : " + highscore;
        Debug.Log("Current highscore is: " + highscore);
    }
	
	// Update is called once per frame
	void Update ()
    {
    }
}
