﻿using UnityEngine.Audio;
using UnityEngine;


[System.Serializable]
public class Sound
{
    public string name; 

    public AudioClip clip;

    [Range(0f,1f)]
    public float volume;
    [Range(0f, 1f)]
    public float pitch;

    public bool loop;

    [HideInInspector] // Because this will be autopopulated
    //from the Awake method of the class
    public AudioSource source;



}
