using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip[] musicClips;
    public AudioClip[] sfxClips;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        PlayMusic(0);
    }

    public void PlayMusic(int clip)
    {
        musicSource.clip = musicClips[clip];
        musicSource.Play();
    }

    public void PlaySFX(int clip)
    {
        sfxSource.clip = sfxClips[clip];
        sfxSource.Play();
    }

}
