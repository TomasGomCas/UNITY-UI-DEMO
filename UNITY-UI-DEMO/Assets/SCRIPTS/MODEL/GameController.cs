using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public MusicController musicController;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        musicController = this.gameObject.AddComponent<MusicController>();
        //musicController.enabled = true;
    }

    void Update()
    {
        
    }
}
