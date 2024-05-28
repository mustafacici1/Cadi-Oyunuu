using UnityEngine;

public class NesneYaklasma : MonoBehaviour
{
    public GameObject messageUI;  // Mesajın gösterileceği UI elementi
    private bool isNear = false;

    void Start()
    {
        if (messageUI != null)
        {
            messageUI.SetActive(false );  // Başlangıçta mesajı gizliyoruz
        }
    }

    void Update()
    {
        if (isNear && Input.GetKeyDown(KeyCode.E))
        {
            // Nesneyi alma işlemi burada gerçekleşebilir
            Debug.Log("Nesne alındı!");
            if (messageUI != null)
            {
                messageUI.SetActive(false);  // Mesajı gizle
            }
            Destroy(gameObject);  // Nesneyi yok et (veya başka bir işlem yap)
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNear = true;
            if (messageUI != null)
            {
                Debug.Log("sa");
                messageUI.SetActive(true);  // Mesajı göster
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNear = false;
            if (messageUI != null)
            {
                messageUI.SetActive(false);  // Mesajı gizle
            }
        }
    }
}