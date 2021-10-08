using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Byter scen till nästa
    }

    public void QuitGame()
    {
        Application.Quit(); //Stänger ner spelet
        print("Working"); //För att se om den fungerar
    }
}
