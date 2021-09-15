using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class scene_options : MonoBehaviour
{
   public GameObject gameController;
   public GameController controller;

    public Button button_back;
    public Slider slider_volume;
    public Dropdown dropdown_language;

    void Start()
    {
        this.button_back = GameObject.Find("button_back").GetComponent<Button>();
        this.button_back.onClick.AddListener(back);

        this.dropdown_language = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        this.dropdown_language.onValueChanged.AddListener(delegate { changeLanguage(); });

        if (LocalizationSettings.SelectedLocale.name == "Spanish (es)") {
            Debug.Log("ESPAGNOL");
        }
        else if (LocalizationSettings.SelectedLocale.name == "English (en)") {
            Debug.Log("INGLE");
        }

        gameController = GameObject.Find("GameController");
        this.controller = this.gameController.GetComponent("GameController") as GameController;

        this.slider_volume = GameObject.Find("slider_volume").GetComponent<Slider>();
        this.slider_volume.value = this.controller.musicController.music_main.volume;
        this.slider_volume.onValueChanged.AddListener(delegate { volume(); });
    }

    void Update()
    {
        
        
    }

    void changeLanguage() {

        // 0 - English
        // 1 - Spanish

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[this.dropdown_language.value];

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
