using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class prue : MonoBehaviour
{

    Button boton;
    Text texto;
    // Start is called before the first frame update
    void Start()
    {
        boton = GameObject.Find("Button").GetComponent<Button>();
        texto = GameObject.Find("Text").GetComponent<Text>();
        boton.onClick.AddListener(prueba);
    }

    public void prueba() {
        Datos.nombre = "farlopa";
        SceneManager.LoadScene("MAIN MENU 2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
