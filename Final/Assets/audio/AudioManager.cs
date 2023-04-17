using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] sonidos;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        foreach (var s in sonidos)
        {
           s.source= gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.playOnAwake = s.playOnAwake;
            if(s.playOnAwake)
                s.source.Play();
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sonidos, sound => sound.name == name);
        if (s != null)
            s.source.Play();
        else
            print("El sonido: " + name + " no existe");

    }
}
