using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void load()
    {
        Debug.Log("LOOOOOOOAAAAAAAAAD");

        Debug.Log("MENU : " + Cache.email);

        Cache.email = "";
          Cache.language = "";
          Cache.nick = "";
          Cache.points = "";

          //string email = this.controller.firebaseAuthController.auth.CurrentUser.Email;
          //xCache.email = email;
        Debug.Log("LOOOOOOOAAAAAAAAAD 2");
        this.controller.restController.getUserInfo();

    }
}
