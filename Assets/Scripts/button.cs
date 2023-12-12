using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour

{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Player Controle");
    }

    public void restart()
    {
        SceneManager.LoadScene("main menu");
    }

    public void Information()
    {
        SceneManager.LoadScene("information");
    }
}
