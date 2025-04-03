using UnityEngine;
using MidiJack;

public class PauseMusic : MonoBehaviour
{
    public TrackWaveFrom trackScript; // Référence au script qui gère la waveform
    public AudioSource AudioSource;  // Référence à l'AudioSource pour la gestion de la musique
    private bool isPaused = false;

    private void Start()
    {
        // Récupère l'AudioSource et le script de la waveform
        //AudioSource = GetComponent<AudioSource>();

        if (trackScript == null)
        {
            Debug.LogError("Track script reference is not assigned!");
        }
    }

    private void Update()
    {
        // Vérifie si le bouton est pressé. Remplace cette condition par celle qui convient pour ta tablette.
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
            trackScript.ResumeWaveform(); // Appel à une méthode dans le script Track pour relancer la waveform
        }
        else
        {
            // Mets la musique et la waveform en pause
            AudioSource.Pause();
            trackScript.PauseWaveform(); // Appel à une méthode dans le script Track pour mettre la waveform en pause
        }

        // Change l'état de pause
        isPaused = !isPaused;
    }
}