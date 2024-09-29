using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] sounds;

    private void Awake()
    {
        Instance = this;

        foreach (var item in sounds)
        {
            item.source = gameObject.AddComponent<AudioSource>();
            item.source.clip = item.clip;
            item.source.volume = item.volume;
            item.source.pitch = item.pitch;
            item.source.loop = item.loop;
            item.source.playOnAwake = item.playOnAwake;

            if (item.playOnAwake)
            {
                item.source.Play();
            }
        }
    }
}
