using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score2;
    public Text scoreText;

    public int Highscore;
    public Text HighscoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        Highscore = PlayerPrefs.GetInt("Highscore", Highscore);  //Laddar highscoren -Oliver
    }

    // Update is called once per frame   
    void Update()
    {
        score2 = alien.score;

        scoreText.text = score2 + ""; //Ändrar score texten   -Oliver

        if(score2 > Highscore)  //Ändrar highscoren  -Oliver
        {
            Highscore = score2;
        }

        HighscoreText.text = "Highscore " + Highscore;  //Ändrar highscore texten  -Oliver

        PlayerPrefs.SetInt("Highscore", Highscore);  //Sparar highscoren  -Oliver

    }
}
