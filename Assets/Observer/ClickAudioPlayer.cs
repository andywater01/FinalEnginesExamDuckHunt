using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAudioPlayer : MonoBehaviour
{
    public AudioSource _audiosource;

    private void Awake() {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable() {
        checkClick.userClick += PlayAudio;
    }

    private void OnDisable() {
        checkClick.userClick -= PlayAudio;
    }

    private void PlayAudio(){
        _audiosource.Play();
        Debug.Log("Observer Playing");
    }
}
