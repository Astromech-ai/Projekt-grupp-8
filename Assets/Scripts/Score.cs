using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score;
    public Text scoreText;

    public bool test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame   
    void Update()
    {
        scoreText.text = score + ""; //Ändrar score texten


        if(test == true)
        {

        }
    }
}
