using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scene_mainmenu : MonoBehaviour
{
    public Button button;
    public GameObject gameController;
    public GameController controller;

    void Start()
    {
       
                    Debug.Log("MENU: " + Cache.email);

        gameController = GameObject.Find("GameController");
        this.controller = this.gameController.GetComponent("GameController") as GameController;

        this.button = GameObject.Find("button_rankedmatch").GetComponent<Button>();
        this.button.onClick.AddListener(button_rankedmatch);

        this.button = GameObject.Find("button_custommatch").GetComponent<Button>();
        this.button.onClick.AddListener(button_custommatch);

    }

    void Update()
    {
        
    }

    void button_rankedmatch()
    {
        this.controller.musicController.audioClick();
        SceneManager.LoadScene("scene_rankedmatch");
    }

    void button_custommatch()
    {
        this.controller.musicController.audioClick();
        SceneManager.LoadScene("scene_options");
    }
}
