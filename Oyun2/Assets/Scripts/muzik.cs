using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzik : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    public AudioClip background;
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();

    }
}