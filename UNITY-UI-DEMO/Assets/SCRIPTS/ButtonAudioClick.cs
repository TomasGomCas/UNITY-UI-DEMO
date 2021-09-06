using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAudioClick : MonoBehaviour
{
    public AudioSource audioSource;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        this.button = GetComponent<Button>();
        button.onClick.AddListener(playSound);
    }

    void playSound() {
        this.audioSource.Play();
    }

}
