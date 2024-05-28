using UnityEngine;
using UnityEngine.SceneManagement;

public class KapıKontrol : MonoBehaviour
{
    // Tetikleyici alanına giren GameObject'i kontrol eden değişken
    public GameObject targetObject;
    private bool isTargetObjectNearby = false; // Hedef nesnenin yakın olup olmadığını kontrol eder

    private void OnTriggerEnter(Collider other)
    {
        // Tetikleyici alanına giren nesnenin hedef nesne olup olmadığını kontrol eder
        if (other.gameObject == targetObject)
        {
            isTargetObjectNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Tetikleyici alanından çıkan nesnenin hedef nesne olup olmadığını kontrol eder
        if (other.gameObject == targetObject)
        {
            isTargetObjectNearby = false;
        }
    }

    private void Update()
    {
        // Hedef nesne tetikleyici alanında ve "E" tuşuna basılmışsa sahneyi yükle
        if (isTargetObjectNearby && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadSceneAsync(4);
        }
    }
}
