using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class OptionScene : MonoBehaviour
{
   public GameObject gameController;
   public GameController controller;

    public Button button_back;
    public Slider slider_volume;
    public Dropdown dropdown_language;

    public Text text_nick;
    public Text text_email;
    public Text text_points;

    void Start()
    {
        gameController = GameObject.Find("GameController");
        this.controller = this.gameController.GetComponent("GameController") as GameController;

        this.text_nick = GameObject.Find("text_nick").GetComponent<Text>();
        this.text_nick.text = this.text_nick.text + Cache.nick;

        this.text_email = GameObject.Find("text_email").GetComponent<Text>();
        this.text_email.text = this.text_email.text + Cache.email;

        this.text_points = GameObject.Find("text_points").GetComponent<Text>();
        this.text_points.text = this.text_points.text + Cache.points;

        this.button_back = GameObject.Find("button_back").GetComponent<Button>();
        this.button_back.onClick.AddListener(back);

        this.dropdown_language = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        this.dropdown_language.value = this.controller.localizationController.getLocationCode(Cache.language);
        this.dropdown_language.onValueChanged.AddListener(delegate { changeLanguage(); });

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
