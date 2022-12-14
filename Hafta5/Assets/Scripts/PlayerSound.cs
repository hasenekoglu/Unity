using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerSound : MonoBehaviour
{
    public AudioSource jumpSFx;
    public AudioClip[] jumpClips;
    public AudioSource dieSFx;
    public AudioClip[] dieClips;

    public void PlayRandomJumpSFx()
    {
        PlayRandomSound(jumpSFx,jumpClips);
    }

    public void PlayRandomDieSFx()
    {
        PlayRandomSound(dieSFx,dieClips);
    } 
    private void PlayRandomSound(AudioSource audioSource,AudioClip[] audioClips)
    {
        var randomClipIndex = Random.Range(0, audioClips.Length);
        var randomClip = audioClips[randomClipIndex];
        audioSource.clip = randomClip;
        audioSource.Play();
    }
    
}