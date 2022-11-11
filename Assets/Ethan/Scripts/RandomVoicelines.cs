using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomVoicelines : MonoBehaviour
{
    public AudioSource audiosource;

    public AudioClip[] voicelines;

    public int randomButtonSound;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        // Play one random sound between two audio clips everytime you press the button
        randomButtonSound = Random.Range(0, 2);
        audiosource.PlayOneShot(voicelines[randomButtonSound]);
    }
}
