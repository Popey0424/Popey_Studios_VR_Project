using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumLaserAnimation : MonoBehaviour
{
    [Header("Animate Up and Down")]
    public List<Animator> LasersAnimators = new List<Animator>();
    public bool isAnimationWork;

    [Header("Block Laser")]
   
    public bool isLasersDown;

    #region BlockLaserDown
    public void OnClickBlockDownLaser()
    {
        if (!isLasersDown)
        {
            BlockLaserDown(true);
            isLasersDown = true;
        }
        else if (isLasersDown)
        {
            BlockLaserDown(false);
            isLasersDown = false;
        }
    }

    private void BlockLaserDown(bool blockLaser)
    {
        foreach (var animator in LasersAnimators)
        {
            animator.SetBool("BlockLaser", blockLaser);
        }
    }
    #endregion

    #region Animation LaserUpDown
    public void OnClickAnimation()
    {
        if (!isAnimationWork)
        {
            LaserUpAndDown(true);
            isAnimationWork = true;
        }
        else if (isAnimationWork)
        {
            LaserUpAndDown(false);
            isAnimationWork = false;
        }
    }


    private void LaserUpAndDown( bool OnOff)
    {
        foreach(var animator in LasersAnimators)
        {
            animator.SetBool("UpDown", OnOff);
        }
    }
    #endregion
}
