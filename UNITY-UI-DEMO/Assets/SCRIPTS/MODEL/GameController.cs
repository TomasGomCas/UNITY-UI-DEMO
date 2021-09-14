using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public MusicController musicController;

    void Start()
    {

        int numMusicPlayers = FindObjectsOfType<GameController>().Length;
        if (numMusicPlayers != 1)
        {
            Destroy(this.gameObject);
        }
        // if more then one music player is in the scene
        //destroy ourselves
        else
        {
            DontDestroyOnLoad(gameObject);
        }

        // DontDestroyOnLoad(this.gameObject);
        musicController = this.gameObject.AddComponent<MusicController>();
        //musicController.enabled = true;
    }

    void Update()
    {
        
    }
}
