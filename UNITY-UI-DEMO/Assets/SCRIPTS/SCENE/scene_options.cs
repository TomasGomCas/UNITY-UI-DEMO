using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scene_options : MonoBehaviour
{
    public GameObject gameController;
    public GameController controller;

    public Button button_back;
    public Slider slider_volume;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController");
        this.controller = this.gameController.GetComponent("GameController") as GameController;

        this.button_back = GameObject.Find("button_back").GetComponent<Button>();
        this.button_back.onClick.AddListener(back);

        this.slider_volume = GameObject.Find("slider_volume").GetComponent<Slider>();
        this.slider_volume.value = this.controller.musicController.music_main.volume;
        this.slider_volume.onValueChanged.AddListener(delegate { volume(); });
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void back()
    {
        this.controller.musicController.audioClick();
        SceneManager.LoadScene("scene_mainmenu");
    }

    void volume()
    {
        this.controller.musicController.music_main.volume = this.slider_volume.value;
    }

}
