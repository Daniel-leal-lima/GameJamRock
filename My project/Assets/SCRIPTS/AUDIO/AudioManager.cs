using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;


    public static AudioManager instance;
//    public Sound currentSound;
      HashSet<Sound> activeAudios = new HashSet<Sound>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Som: " + name + " não encontrado!");
            return;
        }
        activeAudios.Add(s);
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Som: " + name + " não encontrado!");
            return;
        }
        activeAudios.Remove(s);
        s.source.Stop();
    }

    public void SetVolume(float volume)
    {
        foreach (Sound s in sounds)
        {
            s.source.volume = volume;
        }
    }
    public void SetVolume(string name, float volume)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Som: " + name + " não encontrado!");
            return;
        }
        s.source.volume = volume;
    }

    public float GetVolume()
    {
        return sounds[0].source.volume;
    }
    
    public void Restart(string name)
    {
        Stop(name);
        Play(name);
    }
}
