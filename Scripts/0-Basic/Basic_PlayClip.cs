using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Basic_PlayClip 
{
    public Animator AnimMaster;
    public void PlayClip(AnimationClip clip) 
    {
        AnimMaster.Play(clip.name);
    }
}
