﻿
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioClip build;

    [SerializeField]
    AudioClip hit;

    [SerializeField]
    AudioClip jump;

    public AudioClip Build
    {
        get
        {
            return build;
        }
    }

    public AudioClip Hit
    {
        get
        {
            return hit;
        }
    }

    public AudioClip Jump
    {
        get
        {
            return jump;
        }
    }

}
