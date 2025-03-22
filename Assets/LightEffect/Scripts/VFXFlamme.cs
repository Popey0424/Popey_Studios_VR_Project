using System.Collections.Generic;
using UnityEngine;

public class VFXFlamme : MonoBehaviour
{
    public List<ParticleSystem> FlamesThrower = new List<ParticleSystem>();
    private bool isFlameActive = false;
    private bool isAnimationOn = false;
    public List<Animator> FlamesAnimator = new List<Animator>();

    [Header("AudioSource Settings")]
    public AudioSource audioSource;
    public float[] spectrumData = new float[256];
    public float FlameThreshold = 0.05f;



    private void Start()
    {
        foreach (ParticleSystem go in FlamesThrower)
        {
            go.Stop();
        }
    }

    void Update()
    {
        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.Rectangular);

        if (IsTrebleHitFlame())
        {

            TurnOnFlames();

        }
        else
        {
            TurnOffFlames();
        }
    }

    public bool IsTrebleHitFlame()
    {
        float bassEnergy = spectrumData[1] + spectrumData[2] + spectrumData[3];  // Fréquences basses
        return bassEnergy > FlameThreshold;
    }


    public void OnLeftRightAnimation()
    {
        if (isFlameActive && !isAnimationOn)
        {
            PlayAnimation(true);
            isAnimationOn = true;
        }
        else if (isFlameActive && isAnimationOn)
        {
            PlayAnimation(false);
            isAnimationOn = false;
        }
    }

    private void PlayAnimation(bool newBool)
    {
        foreach (Animator anim in FlamesAnimator)
        {
            anim.SetBool("LeftRight", newBool);
        }
    }


    public void TurnOnFlames()
    {


        foreach (ParticleSystem go in FlamesThrower)
        {
            go.Play();

        }



    }

    public void TurnOffFlames()
    {


        foreach (ParticleSystem go in FlamesThrower)
        {
            go.Stop(true, ParticleSystemStopBehavior.StopEmitting);

        }

    }
}
