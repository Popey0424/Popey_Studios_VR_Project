using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWaveForm : MonoBehaviour
{
    public AudioSource audioSource;
    private float[] samples;


   
    void Start()
    {
        int sampleSize = 1024;
        samples = new float[sampleSize];
            
    }


    void Update()
    {
        if (audioSource.isPlaying)
        {
            audioSource.GetOutputData(samples, 0);
            //audioSource.GetSpectrumData(samples, 0, FFTWindow.BlackmanHarris);
        }
    }
}
