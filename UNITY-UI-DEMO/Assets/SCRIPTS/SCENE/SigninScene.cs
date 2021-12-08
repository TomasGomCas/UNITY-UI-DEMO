using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SigninScene : MonoBehaviour
{
    public GameObject gameController;
    public GameController controller;
    public Button button_signin;
    public InputField input_email;
    public InputField input_password;
    public GameObject panel_popup;
    public Button button_popup;
    public Image imagen;
    public GameObject canvas_textload;
    public GameObject canvas_imageload;

    Firebase.Auth.FirebaseAuth auth;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController");
        this.controller = this.gameController.GetComponent("GameController") as GameController;

        this.canvas_textload = GameObject.Find("canvas_textload");
        this.canvas_textload.SetActive(false);
        this.canvas_imageload = GameObject.Find("canvas_imageload");
        this.canvas_imageload.SetActive(false);

        this.button_signin = GameObject.Find("button_signin").GetComponent<Button>();
        this.button_signin.onClick.AddListener(signin);

        this.button_popup = GameObject.Find("button_pop").GetComponent<Button>();
        this.button_popup.onClick.AddListener(popupButton);

        this.input_email = GameObject.Find("input_email").GetComponent<InputField>();
        this.input_password = GameObject.Find("input_password").GetComponent<InputField>();

        this.panel_popup = GameObject.Find("CanvasPopup");
        this.panel_popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    async void signin()
    {
        this.canvas_textload.SetActive(true);
        this.canvas_imageload.SetActive(true);
        this.controller.loadService.rotate();

        bool b = await this.controller.firebaseAuthController.signinWithEmailPassword(this.input_email.text, this.input_password.text);

        if (b == true) {
            this.canvas_textload.SetActive(false);
            this.canvas_imageload.SetActive(false);
            SceneManager.LoadScene("scene_intro_load");
        }
        else {
            this.canvas_textload.SetActive(false);
            this.canvas_imageload.SetActive(false);
            this.panel_popup.SetActive(true);
            Debug.Log("ERROR EN EL LOGIN");
        }
    }

    private void popupButton() {
        this.panel_popup.SetActive(false);
    }

}
