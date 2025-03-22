using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumAnalyzer : MonoBehaviour
{
    public AudioSource audioSource;
    public float[] spectrumData = new float[256];  // Stocke les fr�quences

    public float trebleThreshold = 0.05f;  // Sensibilit� des aigus

    void Update()
    {
        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);
    }

    public bool IsTrebleHit()
    {
        float trebleEnergy = 0;

        // Additionne les valeurs des fr�quences aigu�s
        for (int i = 40; i < 80; i++)
        {
            trebleEnergy += spectrumData[i];
        }

        return trebleEnergy > trebleThreshold;
    }
}
