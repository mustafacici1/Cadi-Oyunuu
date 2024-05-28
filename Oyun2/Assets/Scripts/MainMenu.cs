using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        
    }

    public void Yapanlar()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void  Nasıl()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
