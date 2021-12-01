using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;
public class scene_intro_load : MonoBehaviour
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
        Debug.Log("ANTES: " + Cache.email);
        Cache.email = "pruebaDespues";
        Debug.Log("DESPUES: " + Cache.email);

        SceneManager.LoadScene("scene_mainmenu");
    }

    async private void load()
    {
        await this.controller.restController.getUserInfo();
        Debug.Log("LANGUAGE DE BBDD: " + Cache.language);
        this.controller.localizationController.setLocation(Cache.language);
        Debug.Log("LANGUAGE DE BBDD: " + this.controller.localizationController.name);
        SceneManager.LoadScene("scene_mainmenu");
    }
}

