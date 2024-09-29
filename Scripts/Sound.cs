using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{   
    [HideInInspector] public AudioSource source;  
    [Range (0, 1)] public float volume;
    [Range (-3, 3)] public float pitch;

    public string name;
    public AudioClip clip;
    public bool playOnAwake;
    public bool loop;
}
