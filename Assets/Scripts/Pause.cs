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
        buttons.SetActive(false);  //Döljer knapparna  -Oliver
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false) //Pausar spelet när man trycker på escape  -Oliver
        {
            Time.timeScale = 0;  //Stannar tiden   -Oliver
            buttons.SetActive(true);  //Visar knapparna   -Oliver
        }
        
    }

    public void Continue()
    {
        Time.timeScale = 1;  //Får tiden att bli normal   -Oliver
        buttons.SetActive(false);  //Döljer knapparna  -Oliver  
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);  //Byter till menyn   -Oliver
        Time.timeScale = 1;  //Får tiden att bli normal   -Oliver
    }

}
