using MidiJack;
using UnityEngine;

public class MidiControllerInput : MonoBehaviour
{
    public int pauseButtonID = 11; // ID du bouton de pause (même pour les 2 decks)

    // Références aux sources audio et aux scripts de la waveform pour chaque deck
    public AudioSource audioSourceDeck1;
    public AudioSource audioSourceDeck2;
    public TrackWaveFrom trackScriptDeck1;
    public TrackWaveFrom trackScriptDeck2;

    // Mets ici les IDs détectés avec `MidiInputDebugger`
    public int midiPortDeck1 = 0;  // Remplace par l'ID du premier deck
    public int midiPortDeck2 = 1;  // Remplace par l'ID du second deck

    private bool isPausedDeck1 = false;
    private bool isPausedDeck2 = false;

    private void Update()
    {
        if (MidiMaster.GetKeyDown(pauseButtonID))
        {
            int detectedPort = GetMidiDevicePort();
            if (detectedPort == midiPortDeck1)
            {
                TogglePauseDeck(1);
            }
            else if (detectedPort == midiPortDeck2)
            {
                TogglePauseDeck(2);
            }
        }
    }

    private int GetMidiDevicePort()
    {
        for (int note = 0; note < 128; note++)
        {
            float value = MidiMaster.GetKey(note);
            if (value > 0)
            {
                return MidiMaster.GetKeyDevice(note); // Renvoie l'ID du périphérique MIDI
            }
        }
        return -1; // Aucun signal MIDI détecté
    }

    private void TogglePauseDeck(int deck)
    {
        if (deck == 1)
        {
            isPausedDeck1 = !isPausedDeck1;
            if (isPausedDeck1)
            {
                audioSourceDeck1.Pause();
                trackScriptDeck1.PauseWaveform();
            }
            else
            {
                audioSourceDeck1.UnPause();
                trackScriptDeck1.ResumeWaveform();
            }
        }
        else if (deck == 2)
        {
            isPausedDeck2 = !isPausedDeck2;
            if (isPausedDeck2)
            {
                audioSourceDeck2.Pause();
                trackScriptDeck2.PauseWaveform();
            }
            else
            {
                audioSourceDeck2.UnPause();
                trackScriptDeck2.ResumeWaveform();
            }
        }
    }
}