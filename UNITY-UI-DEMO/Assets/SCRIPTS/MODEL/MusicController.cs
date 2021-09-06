using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource music_main;
    public AudioClip clip;

    void Start()
    {
        //music_main.volume = 0.5f;
        music_main = this.gameObject.AddComponent<AudioSource>();
        music_main.clip = Resources.Load("audio/BANDASONORA") as AudioClip; 
        music_main.Play();
    }

    void Update()
    {

    }

    public void setVolume_music(float volume){
       // this.music_main.volume = volume;
    }

    public void audioClick() {
        // effect_buttonClick.Play();
        //Debug.Log("MI PENE");
        this.music_main.volume = 0;
    }
}
