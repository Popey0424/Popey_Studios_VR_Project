using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassAnalyzer : MonoBehaviour
{
    public AudioSource audioSource;
    public float[] spectrumData = new float[256];  // Stocke les fr�quences
    public float bassThreshold = 0.1f;  // Sensibilit� des basses
 
    void Update()
    {
        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);
    }

    public bool IsBassHit()
    {
   
        float bassEnergy = spectrumData[1] + spectrumData[2] + spectrumData[3];  // Fr�quences basses
        return bassEnergy > bassThreshold;
    }
}
