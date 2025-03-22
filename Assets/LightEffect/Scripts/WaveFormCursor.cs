using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveFormCursor : MonoBehaviour
{
    public AudioSource audioSource;
    public RectTransform waveformRect; // Le conteneur de la waveform
    public RectTransform cursor; // Le curseur fixe au centre

    private float waveformWidth;
    private float halfCursorX;

    void Start()
    {
        waveformWidth = waveformRect.rect.width;
        halfCursorX = cursor.anchoredPosition.x; // Garde la position centrale du curseur
    }

    void Update()
    {
        if (audioSource.clip == null) return;

        // Calcul du pourcentage d'avancement
        float progress = audioSource.time / audioSource.clip.length;

        // Position de la waveform (inversée pour donner l'effet de défilement)
        float offsetX = -waveformWidth * progress + halfCursorX;

        // Applique la nouvelle position
        waveformRect.anchoredPosition = new Vector2(offsetX, waveformRect.anchoredPosition.y);
    }
}
