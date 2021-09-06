using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListaDesplegable : MonoBehaviour
{
    public Dropdown listaDesplegable; 
    void Start()
    {
        Datos.options.Add("Spanish");
        Datos.options.Add("English");
        Datos.options.Add("French");

        listaDesplegable.ClearOptions();
        listaDesplegable.AddOptions(Datos.options);
    }

    private void Update()
    {
       // Debug.Log(listaDesplegable.options[listaDesplegable.value].text);
    }

}
