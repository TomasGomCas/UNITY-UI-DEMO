using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScene : MonoBehaviour
{
    public GameObject gameController;
    public GameController controller;
    // private bool showPopUp = true;
    // Start is called before the first frame update
    public Button button_back;


    void Start()
    {
        gameController = GameObject.Find("GameController");
        this.controller = this.gameController.GetComponent("GameController") as GameController;

        this.button_back = GameObject.Find("button_back").GetComponent<Button>();
        this.button_back.onClick.AddListener(back);
        // OnGUI();
    }

    void back()
    {
        this.controller.firebaseAuthController.googleAuth();
        Debug.Log("BOTTON CLICK");
    }


    /* void OnGUI()
     {
         if (showPopUp)
         {
             GUI.Window(0, new Rect((Screen.width / 2) - 150, (Screen.height / 2) - 75
                    , 1000, 500), ShowGUI, "Invalid word");

         }
     }
     // Update is called once per frame
     void Update()
     {

     }

     void ShowGUI(int windowID)
     {
         // You may put a label to show a message to the player

         GUI.Label(new Rect(500, 250, 1000, 500), "EMAIL/PASSWORD ERROR");

         // You may put a button to close the pop up too

         if (GUI.Button(new Rect(50, 150, 75, 30), "OK"))
         {
             showPopUp = false;
             // you may put other code to run according to your game too
         }

     }*/
}
