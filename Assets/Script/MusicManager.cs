using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioSource music;
    public void OnMusic() {
        music.Play();
    }

    public void offMusic()
    {
        music.Stop();
    }
}