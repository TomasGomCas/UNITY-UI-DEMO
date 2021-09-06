using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PruebaText : MonoBehaviour
{
    Text text;
    Button button;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
        button = GameObject.Find("jaja").GetComponent<Button>();

        button.onClick.AddListener(cambiarText);
        text.text = Datos.nombre;//Application.nombre + Application.dinero;
    }

    public void cambiarText() {
        Debug.Log("You have clicked the button!");
        text.text = "Cambio";
        //Application.nombre = text.text;
    }

}
