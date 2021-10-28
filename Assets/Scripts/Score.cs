using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score;
    public Text scoreText;

    public int Highscore;
    public Text HighscoreText;

    public bool test;

    // Start is called before the first frame update
    void Start()
    {
        Highscore = PlayerPrefs.GetInt("Highscore", Highscore);  //Laddar highscoren
    }

    // Update is called once per frame   
    void Update()
    {
        scoreText.text = score + ""; //Ändrar score texten


        if(test == true)  //Lägger till 1 i score när man skjuter en alien
        {
            score = score + 1;
        }

        if(score > Highscore)  //Ändrar highscoren
        {
            Highscore = score;
        }

        HighscoreText.text = "Highscore " + Highscore;  //Ändrar highscore texten

        PlayerPrefs.SetInt("Highscore", Highscore);  //Sparar highscoren
    }
}
