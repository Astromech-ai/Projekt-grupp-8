using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject buttons;

    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        buttons.SetActive(false);  //Döljer knapparna
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false) //Pausar spelet när man trycker på escape
        {
            Time.timeScale = 0;  //Stannar tiden   
            buttons.SetActive(true);  //Visar knapparna   
        }
        
    }

    public void Continue()
    {
        Time.timeScale = 1;  //Får tiden att bli normal   
        buttons.SetActive(false);  //Döljer knapparna   
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);  //Byter till menyn   
        Time.timeScale = 1;  //Får tiden att bli normal   
    }

}
