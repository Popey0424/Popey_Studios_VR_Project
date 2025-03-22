using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAnalyzer : MonoBehaviour
{
    
    public AudioSource AudioSource; // récup l'audio source pour pouvoir l'analyser
    public int NumberOfSamples = 64; // nombre de sample analyser par défaut 64 
    public float[] SpectrumData; // spectre des frequance en float 


    private void Start()
    {
        SpectrumData = new float[NumberOfSamples];
    }


    private void Update()
    {
        AudioSource.GetSpectrumData(SpectrumData, 0, FFTWindow.BlackmanHarris); //BlackmanHarris (Basses) mais ici peut importe on recupere tout de meme l'entierte du son 
    }
}
