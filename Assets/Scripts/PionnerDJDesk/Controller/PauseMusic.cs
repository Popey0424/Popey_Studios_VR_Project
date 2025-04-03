using UnityEngine;
using MidiJack;

public class PauseMusic : MonoBehaviour
{
    public TrackWaveFrom trackScript; // R�f�rence au script qui g�re la waveform
    public AudioSource AudioSource;  // R�f�rence � l'AudioSource pour la gestion de la musique
    private bool isPaused = false;

    private void Start()
    {
        // R�cup�re l'AudioSource et le script de la waveform
        //AudioSource = GetComponent<AudioSource>();

        if (trackScript == null)
        {
            Debug.LogError("Track script reference is not assigned!");
        }
    }

    private void Update()
    {
        // V�rifie si le bouton est press�. Remplace cette condition par celle qui convient pour ta tablette.
        if (MidiMaster.GetKeyDown(11)) 
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        if (isPaused)
        {
            // Relance la musique et la waveform
            AudioSource.UnPause();
            trackScript.ResumeWaveform(); // Appel � une m�thode dans le script Track pour relancer la waveform
        }
        else
        {
            // Mets la musique et la waveform en pause
            AudioSource.Pause();
            trackScript.PauseWaveform(); // Appel � une m�thode dans le script Track pour mettre la waveform en pause
        }

        // Change l'�tat de pause
        isPaused = !isPaused;
    }
}