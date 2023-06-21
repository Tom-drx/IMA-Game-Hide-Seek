using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFollower : MonoBehaviour
{
    private AudioSource audioSource;
    private Transform characterTransform;
    private float volumeIncrement = 0.05f;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        characterTransform = transform; // Assuming the script is attached to the character itself.
    }

    private void Update()
    {
        // Increase volume by pressing the 'C' key
        if (Input.GetKeyDown(KeyCode.C))
        {
            audioSource.volume = Mathf.Clamp(audioSource.volume + volumeIncrement, 0f, 1f);
        }
        // Decrease volume by pressing the 'V' key
        else if (Input.GetKeyDown(KeyCode.V))
        {
            audioSource.volume = Mathf.Clamp(audioSource.volume - volumeIncrement, 0f, 1f);
        }

        audioSource.transform.position = characterTransform.position;
    }
}