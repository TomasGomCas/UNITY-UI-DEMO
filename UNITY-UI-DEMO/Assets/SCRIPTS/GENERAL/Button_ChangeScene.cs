using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_ChangeScene : MonoBehaviour
{
    public string scene;
    public string buttonId;
    private Button button;

    void Start()
    {
        this.button = GameObject.Find(buttonId).GetComponent<Button>();
        this.button.onClick.AddListener(cargarEscena);
    }

   void cargarEscena() {
        SceneManager.LoadScene(scene);
    }


}
