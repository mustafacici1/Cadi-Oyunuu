using UnityEngine;
using System.Collections;

public class ShowMessage : MonoBehaviour
{
    public GameObject  messageText; // TextMeshPro UI öğesi referansı
    public GameObject image;
    public float displayDuration = 5.0f; // Mesajın gösterim süresi

    void Start()
    {
        if (messageText == null)
        {
            Debug.LogError("Message Text is not assigned!");
            return;
        }

        // Başlangıçta TextMeshPro öğesini devre dışı bırak
        messageText.SetActive(false);

        // Coroutine'i başlat
        StartCoroutine(ShowMessageForTime());
    }

    IEnumerator ShowMessageForTime()
    {
        // Mesajı görünür yap
        messageText.SetActive(true);


        // Belirtilen süre boyunca bekle
        yield return new WaitForSeconds(displayDuration);

        // Mesajı tekrar devre dışı bırak
        messageText.SetActive(false);
        image.SetActive(false);

    }
}