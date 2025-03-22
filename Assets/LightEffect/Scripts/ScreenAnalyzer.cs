using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAnalyzer : MonoBehaviour
{
    public AudioSource audioSource;
    public float[] spectrumData = new float[256];
    public float bassThreshold = 0.1f;
    public float MediumThreshold = 0.5f;
    

    // Update is called once per frame
    void Update()
    {
        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);
    }

    public bool IsBassHit()
    {
        float bassEnergy = spectrumData[1] + spectrumData[2] + spectrumData[3]; 
        return bassEnergy > bassThreshold;
    }

    public bool IsTrebleHit()
    {
        float trebleEnergy = 0;

   
        for (int i = 40; i < 80; i++)
        {
            trebleEnergy += spectrumData[i];
        }

        return trebleEnergy > MediumThreshold;
    }
}
