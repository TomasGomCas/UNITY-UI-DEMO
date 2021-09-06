using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour
{
    public string escena;
    public string idBoton;
    public Button boton;
    void Start()
    {
        this.boton = GameObject.Find(idBoton).GetComponent<Button>();
        this.boton.onClick.AddListener(cargarEscena);
    }

    void cargarEscena() {
        SceneManager.LoadScene(escena);
    }

}
