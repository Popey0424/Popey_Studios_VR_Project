using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassLaserAnimation : MonoBehaviour
{
    public List<Animator> LeftLaserAnimators = new List<Animator>();
    public List<Animator> RightLaserAnimators = new List<Animator>();

    public bool isOn;
    

    public void OnClickAnimationOn()
    {
        if (!isOn)
        {
            StartAnimation(true);
            isOn = true;
        }
        else if (isOn)
        {
            StartAnimation(false);
            isOn = false;
        }
    }

    private void StartAnimation(bool newBool)
    {
        foreach (Animator anim in LeftLaserAnimators)
        {
            anim.SetBool("LeftSide", newBool);
        }
        foreach (Animator anim in RightLaserAnimators)
        {
            anim.SetBool("RightSide", newBool);
        }
    }
}
