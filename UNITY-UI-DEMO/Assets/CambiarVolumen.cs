using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarVolumen : MonoBehaviour
{
    public Slider slider;
    public

    void Update()
    {
        Datos.volumen = slider.value;
    }
}
