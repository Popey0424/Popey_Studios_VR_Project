//using MidiJack;
//using UnityEngine;
//using UnityEngine.Audio;

//public class MidiControllerAudioEffects : MonoBehaviour
//{
//    // R�f�rences aux sources audio et � l'AudioMixer
//    public AudioSource audioSource;
//    public AudioMixer audioMixer;

//    // IDs des potentiom�tres MIDI pour chaque bande (Basses, M�diums, Aigus)
//    public int bassPotentiometerID = 21;
//    public int midPotentiometerID = 22;
//    public int highPotentiometerID = 23;

//    // Valeurs de contr�le pour chaque bande de fr�quence
//    private float bassValue = 0f;
//    private float midValue = 0f;
//    private float highValue = 0f;

//    private void Update()
//    {
//        // Lire les valeurs des potentiom�tres MIDI
//        bassValue = MidiMaster.GetKey(potentiometerID: bassPotentiometerID);
//        midValue = MidiMaster.GetKey(potentiometerID: midPotentiometerID);
//        highValue = MidiMaster.GetKey(potentiometerID: highPotentiometerID);

//        // Appliquer les valeurs dans l'AudioMixer pour ajuster les bandes de fr�quences
//        audioMixer.SetFloat("BassFrequency", bassValue);
//        audioMixer.SetFloat("MidFrequency", midValue);
//        audioMixer.SetFloat("HighFrequency", highValue);
//    }
//}