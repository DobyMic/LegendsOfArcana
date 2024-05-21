using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] private AudioSource effectsSource, musicSource;
    [SerializeField] private AudioClip victoryClip,defeatClip;

    private void Awake ( )
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad (gameObject);

        }
        else
        {
            Destroy (gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        effectsSource . PlayOneShot (clip);
    }

    public void ChangeMusic(AudioClip music)
    {
        musicSource . clip = music;
        musicSource . Play ();
        musicSource . loop = true;
    }

    public void PlayVictory()
    {
        ChangeMusic (victoryClip);
    }

    public void PlayDefeat()
    {
        ChangeMusic (defeatClip);
    }


    public void toggleSfx()
    {
        effectsSource . mute = !effectsSource . mute;
    }

    public void toggleMusic()
    {
        musicSource . mute = !musicSource . mute;
    }


}
