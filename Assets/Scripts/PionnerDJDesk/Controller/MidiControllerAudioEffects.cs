//using MidiJack;
//using UnityEngine;
//using UnityEngine.Audio;

//public class MidiControllerAudioEffects : MonoBehaviour
//{
//    // Références aux sources audio et à l'AudioMixer
//    public AudioSource audioSource;
//    public AudioMixer audioMixer;

//    // IDs des potentiomètres MIDI pour chaque bande (Basses, Médiums, Aigus)
//    public int bassPotentiometerID = 21;
//    public int midPotentiometerID = 22;
//    public int highPotentiometerID = 23;

//    // Valeurs de contrôle pour chaque bande de fréquence
//    private float bassValue = 0f;
//    private float midValue = 0f;
//    private float highValue = 0f;

//    private void Update()
//    {
//        // Lire les valeurs des potentiomètres MIDI
//        bassValue = MidiMaster.GetKey(potentiometerID: bassPotentiometerID);
//        midValue = MidiMaster.GetKey(potentiometerID: midPotentiometerID);
//        highValue = MidiMaster.GetKey(potentiometerID: highPotentiometerID);

//        // Appliquer les valeurs dans l'AudioMixer pour ajuster les bandes de fréquences
//        audioMixer.SetFloat("BassFrequency", bassValue);
//        audioMixer.SetFloat("MidFrequency", midValue);
//        audioMixer.SetFloat("HighFrequency", highValue);
//    }
//}