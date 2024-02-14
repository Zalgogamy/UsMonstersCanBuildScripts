using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Abstract_AnimatorSate : Basic_PlayClip
{
    public AnimationClip[] clips;
    public AnimationClip IdleClip;
    public void PlayIdle() 
    {
        PlayClip(IdleClip);
    }

}
