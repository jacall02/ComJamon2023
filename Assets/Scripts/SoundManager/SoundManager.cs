using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //control de audio
    private AudioSource controlAudio;

    //array que contenga todos los audioclips del juego
    [SerializeField] private protected AudioClip[] audios;

    public static SoundManager instance; // singleton instance of the GameManager

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); // don't destroy the GameManager object when a new scene is loaded
            DOTween.Init(true, true);
        }
        else
        {
            Destroy(this.gameObject); // if an instance already exists, destroy this one
        }
    }


    void Start()
    {
        //se asocia a elemento AudioSource
        controlAudio = GetComponent<AudioSource>();
        controlAudio.Stop();
    }

    public void PlayEffect(int indice, float volumen)
    {
        controlAudio.PlayOneShot(audios[indice], volumen);
    }

    public void PlayMusic(int indice, float volumen)
    {
        // pone un audioClip con volumen determinado 

        controlAudio.Stop();
        controlAudio.PlayOneShot(audios[indice], volumen);
        
    }
}
