using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualizerVisualizer : MonoBehaviour
{
    public AudioSource audioSource;
    public RectTransform[] bars;
    public int numberOfSamples = 64;
    private float[] spectrumData;

    void Start()
    {
        spectrumData = new float[numberOfSamples];
    }


    void Update()
    {
        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.BlackmanHarris);

  
        for (int i = 0; i < bars.Length; i++)
        {
            float height = Mathf.Clamp(spectrumData[i] * 1000, 1, 200); 
            bars[i].sizeDelta = new Vector2(bars[i].sizeDelta.x, height);
        }
    }
}
