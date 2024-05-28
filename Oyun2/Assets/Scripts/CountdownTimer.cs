using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 120; // 2 dakika (120 saniye)
    public Text timerText;

    void Start()
    {
        if (timerText == null)
        {
            Debug.LogError("Timer Text is not assigned.");
        }
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerText(timeRemaining);
        }
        else
        {
            SceneManager.LoadSceneAsync(5); 
        }
    }

    void UpdateTimerText(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(5); // Sahne indeksi 5 olan sahneye geçiş yap
    }
}
