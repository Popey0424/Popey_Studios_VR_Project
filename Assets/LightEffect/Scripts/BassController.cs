//using MidiJack;
//using UnityEngine;
//using UnityEngine.Audio;

//public class BassController : MonoBehaviour
//{

//    public AudioMixer DJ_Effects;
//    public int cutBasses;
//    public int cutHigh;
//    public int cutMedium;
//    public int cutLPFHPF;
//    public int cutVolume;




//    void Update()
//    {
//        CutBasses();
//        CutHigh();
//        CutMedium();
//        //LPFHPF();
//        CutVolume();
//    }


//    private void CutVolume()
//    {
//        float midiValueVolumeKnob = MidiMaster.GetKnob(cutVolume, 1);



//        float VolumeGain = Mathf.Lerp(0f, 10f, midiValueVolumeKnob);
//        DJ_Effects.SetFloat("VolumeGain", VolumeGain);

//    }
//    private void LPFHPF()
//    {
//        float midiValueLPFHPF = MidiMaster.GetKnob(cutLPFHPF, 0.5f);

//        if (midiValueLPFHPF < 0.5f)
//        {
//            float LPFGain = Mathf.Lerp(0f, -20f, midiValueLPFHPF);
//            DJ_Effects.SetFloat("HighGain", LPFGain);
//            DJ_Effects.SetFloat("MediumGain", LPFGain);
//            DJ_Effects.SetFloat("BassGain", LPFGain);
//        }
//        else if (midiValueLPFHPF > 0.5f)
//        {
//            float HPFGain = Mathf.Lerp(-8f, 10f, midiValueLPFHPF);
//            DJ_Effects.SetFloat("HighGain", HPFGain);
//            DJ_Effects.SetFloat("MediumGain", HPFGain);
//            DJ_Effects.SetFloat("BassGain", HPFGain);

//        }//Corriger quelques truc 
//    }

//    private void CutMedium()
//    {
//        float midiValueMediumVolumeKnob = MidiMaster.GetKnob(cutMedium, 0.5f);

//        if (midiValueMediumVolumeKnob < 0.5f)
//        {
//            float mediumGain = Mathf.Lerp(0f, -20f, midiValueMediumVolumeKnob);
//            DJ_Effects.SetFloat("MediumGain", mediumGain);
//        }
//        else if (midiValueMediumVolumeKnob > 0.5f)
//        {
//            float mediumGain = Mathf.Lerp(-8f, 10f, midiValueMediumVolumeKnob);
//            DJ_Effects.SetFloat("MediumGain", mediumGain);
//        }
//    }

//    private void CutHigh()
//    {
//        float midiValueHighvolumeKnob = MidiMaster.GetKnob(cutHigh, 0.5f);

//        if (midiValueHighvolumeKnob < 0.5f)
//        {
//            float highGain = Mathf.Lerp(0f, -20f, midiValueHighvolumeKnob);
//            DJ_Effects.SetFloat("HighGain", highGain);
//        }
//        else if (midiValueHighvolumeKnob > 0.5f)
//        {
//            float highGain = Mathf.Lerp(-8f, 10f, midiValueHighvolumeKnob);
//            DJ_Effects.SetFloat("HighGain", highGain);
//        }
//    }

//    private void CutBasses()
//    {
//        float midiValueBassesVolumeKnob = MidiMaster.GetKnob(cutBasses, 0.5f);

//        if (midiValueBassesVolumeKnob < 0.5f)
//        {
//            float bassGain = Mathf.Lerp(0f, -20f, midiValueBassesVolumeKnob);
//            DJ_Effects.SetFloat("BassGain", bassGain);
//        }

//        else if (midiValueBassesVolumeKnob > 0.5f)
//        {
//            float bassGain = Mathf.Lerp(-8f, 10f, midiValueBassesVolumeKnob);
//            DJ_Effects.SetFloat("BassGain", bassGain);
//        }




//    }
//}
