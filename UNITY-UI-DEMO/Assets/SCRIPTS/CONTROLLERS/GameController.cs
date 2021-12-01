using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public MusicController musicController;
    public LocalizationController localizationController;
    public RestController restController;
    public FirebaseAuthController firebaseAuthController;

    void Start()
    {

        int numMusicPlayers = FindObjectsOfType<GameController>().Length;
        if (numMusicPlayers != 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

        musicController = this.gameObject.AddComponent<MusicController>();
        localizationController = this.gameObject.AddComponent<LocalizationController>();
        restController = this.gameObject.AddComponent<RestController>();
        firebaseAuthController = this.gameObject.AddComponent<FirebaseAuthController>();
    }

    void Update()
    {
        
    }
}
