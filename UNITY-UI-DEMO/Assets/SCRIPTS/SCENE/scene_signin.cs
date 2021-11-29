using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scene_signin : MonoBehaviour
{
    public GameObject gameController;
    public GameController controller;
    public Button button_signin;
    public InputField input_email;
    public InputField input_password;

    Firebase.Auth.FirebaseAuth auth;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController");
        this.controller = this.gameController.GetComponent("GameController") as GameController;

        this.button_signin = GameObject.Find("button_signin").GetComponent<Button>();
        this.button_signin.onClick.AddListener(signin);

        this.input_email = GameObject.Find("input_email").GetComponent<InputField>();
        this.input_password = GameObject.Find("input_password").GetComponent<InputField>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    async void signin()
    {
        //string a = "puta mierda";
        bool b = await this.controller.firebaseAuthController.signinWithEmailPassword(this.input_email.text, this.input_password.text);

        if (b == true) {
            SceneManager.LoadScene("scene_intro_load");
        }
        else {
            Debug.Log("ERROR EN EL LOGIN");
        }

        //await this.controller.firebaseAuthController.signinWithEmailPassword(this.input_email.text, this.input_password.text)
        //Debug.Log("LOGIN: " + a);
    }

}
