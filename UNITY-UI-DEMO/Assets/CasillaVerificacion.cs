using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasillaVerificacion : MonoBehaviour
{
    public Toggle casillaVerificacion;
    // Start is called before the first frame update
    void Start()
    {
        casillaVerificacion.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(casillaVerificacion.isOn);
    }
}
