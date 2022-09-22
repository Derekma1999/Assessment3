using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sound;
    public AudioClip soundclip;
    void Start()
    {
        //   AudioSource ghostBM = gameObject.GetComponent<AudioSource>();
        //   ghostBM.PlayDelayed(3);
    }

    // Update is called once per frame
    void Update()
    {
        if (!sound.isPlaying)
        {
            sound.PlayOneShot(soundclip);
        }

    }
}
