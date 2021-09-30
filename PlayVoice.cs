using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoice : IAction
{
    [SerializeField] private AudioSource Source;
    public override void Active()
    {
        if (!Source.isPlaying)
        {
            Source.Play();
        }
        else
        {
            Source.Stop();
        }
    }

   
}
