using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        Datos.volumen = 1;
        audioSource.volume = Datos.volumen;
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        audioSource.volume = Datos.volumen;
    }

}
