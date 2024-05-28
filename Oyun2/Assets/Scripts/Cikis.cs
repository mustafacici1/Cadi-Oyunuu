using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cikis : MonoBehaviour
{

    private void Update()
    {
        QuitGame();
    }

    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }


    }
}
