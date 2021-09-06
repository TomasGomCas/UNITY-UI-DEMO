using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MensajePopUp : MonoBehaviour
{

    public Button botonID;
    public GameObject popUp;

    private void Start()
    {
        popUp.SetActive(false);
        botonID.onClick.AddListener(displayPopUp);
    }

    private void displayPopUp() {

        if (popUp.active == true)
        {
            popUp.SetActive(false);
        }
        else {
            popUp.SetActive(true);
        }

    }

}
