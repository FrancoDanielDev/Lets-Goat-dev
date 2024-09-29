using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager2 : MonoBehaviour
{
    public AudioSource brokenBox;
    public AudioSource coin;
    public AudioSource prot_hurt;
    public AudioSource enemy_hurt;
    public AudioSource enemy_dead;
    public AudioSource health_up;
    public AudioSource check;
    public AudioSource cannon;

    public static AudioManager2 Instance;

    private void Awake()
    {
        Instance = this;
        enemy_dead.volume = 3;
    }
}
