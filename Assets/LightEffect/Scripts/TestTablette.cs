//using MidiJack;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Audio;

//public class TestTablette : MonoBehaviour
//{
//    //public AudioSource audioSource;
//    public AudioLowPassFilter lowPassFilter;     // Filtre passe-bas
//    public AudioHighPassFilter highPassFilter;   // Filtre passe-haut
//    public int firstKnobCC;
//    public int VolumeKnobCC;// Premier potentiomètre pour LPF/HPF

  



//    void Update()
//    {

//        LPFHPF();
//        //VolumePitch();
  
//    }


    

//    //private void VolumePitch()
//    //{
//    //    float midiValueVolumeKnob = MidiMaster.GetKnob(VolumeKnobCC, 1);
//    //    audioSource.volume = Mathf.Clamp(midiValueVolumeKnob, 0f, 1f);

//    //}

//    private void LPFHPF()
//    {

//        float midiValueFirstKnob = MidiMaster.GetKnob(firstKnobCC, 0.5f);

//        if (midiValueFirstKnob < 0.5f)
//        {
//        //Controle du LPF
//            float cutoffFrequencyLPF = Mathf.Lerp(200f, 22000f, midiValueFirstKnob * 2);
//            lowPassFilter.cutoffFrequency = cutoffFrequencyLPF;
//            highPassFilter.cutoffFrequency = 10f;
//        }
//        else if (midiValueFirstKnob > 0.5f)
//        {
//        // Controle du HPF
//            float cutoffFrequencyHPF = Mathf.Lerp(20f, 5000f, (midiValueFirstKnob - 0.5f) * 2);
//            highPassFilter.cutoffFrequency = cutoffFrequencyHPF;
//            lowPassFilter.cutoffFrequency = 22000f;
//        }
//    }

    
//}