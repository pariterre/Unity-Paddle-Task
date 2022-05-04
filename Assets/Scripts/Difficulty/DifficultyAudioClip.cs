﻿using UnityEngine;

[System.Serializable]
public class DifficultyAudioClip
{
    public AudioClip audioClip;
    public int difficulty;

    public DifficultyAudioClip(AudioClip audioClipVar, int difficultyVar)
    {
        audioClip = audioClipVar;
        difficulty = difficultyVar;
    }
}
