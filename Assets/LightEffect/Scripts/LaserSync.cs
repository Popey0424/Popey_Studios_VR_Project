using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSync : MonoBehaviour
{
    public AudioSource audioSource;  
    public GameObject laser;         
    public int sampleSize = 17;     
    public float bassThreshold = 0.03f; 
    public float laserIntensityMultiplier = 5f; 
    private float[] spectrumData;

    void Start()
    {
        spectrumData = new float[sampleSize];
    }

    void Update()
    {
        AnalyzeBass();
    }

    void AnalyzeBass()
    {
        if (audioSource.isPlaying)
        {
            audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);

            float bassValue = 0f;
            int bassRange = sampleSize / 10; // On prend une petite portion des basses fréquences

            for (int i = 0; i < bassRange; i++)
            {
                bassValue += spectrumData[i];
            }

            bassValue *= laserIntensityMultiplier;

            // Activation/désactivation du laser en fonction des basses
            if (bassValue > bassThreshold)
            {
                laser.SetActive(true);
            }
            else
            {
                laser.SetActive(false);
            }
        }
    }
}

