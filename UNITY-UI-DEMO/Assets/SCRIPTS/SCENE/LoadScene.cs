using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;
public class LoadScene : MonoBehaviour
{
    public GameObject gameController;
    public GameController controller;

    void Start()
    {
        //StartCoroutine(Example());
        gameController = GameObject.Find("GameController");
        this.controller = this.gameController.GetComponent("GameController") as GameController;
        load();
    }
    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(5);

        Cache.email = "prueba";
        Cache.email = "pruebaDespues";

        SceneManager.LoadScene("scene_mainmenu");
    }

    async private void load()
    {
        await this.controller.restController.getUserInfo();
        this.controller.localizationController.setLocation(Cache.language);
        this.controller.musicController.music_main.volume = PlayerPrefs.GetFloat("volume");
        SceneManager.LoadScene("scene_mainmenu");
    }
}

