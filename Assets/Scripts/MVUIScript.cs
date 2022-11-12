using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MVUIScript : MonoBehaviour
{
    [SerializeField] private GameObject descriptionText;
    public AudioSource Interact;
    public AudioSource Inspect;
    public AudioSource Click;

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShowDescriptionText();
            PlayInspect();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            HideDescriptionText();
            PlayClick();
        }

        if (Input.GetButtonDown("Jump"))
        {
            PlayInteract();
        }
    }

    public void ShowDescriptionText()
    {
        descriptionText.SetActive(true);
    }

    public void HideDescriptionText()
    {
        descriptionText.SetActive(false);
    }

    public void PlayInteract()
    {
        Interact.Play();
    }

    public void PlayInspect()
    {
        Inspect.Play();
    }

    public void PlayClick()
    {
        Click.Play();
    }
}
