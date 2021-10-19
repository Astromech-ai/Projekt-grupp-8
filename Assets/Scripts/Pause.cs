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
        buttons.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            Time.timeScale = 0;
            buttons.SetActive(true);
        }
        
    }

    public void Continue()
    {
        Time.timeScale = 1;
        buttons.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
