using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WaveFromVisualizer : MonoBehaviour
{
    public AudioSource audioSource;
    public RawImage waveformImage;
    public int textureWidth = 1024;
    public int textureHeight = 256;
    public Color waveformColor = Color.black;
    public Color backgroundColor = Color.yellow;

    void Start()
    {
        GenerateWaveform();
    }

    void GenerateWaveform()
    {
        if (audioSource.clip == null) return;

        int samplesCount = audioSource.clip.samples * audioSource.clip.channels;
        float[] samples = new float[samplesCount];
        audioSource.clip.GetData(samples, 0);

        Texture2D waveformTexture = new Texture2D(textureWidth, textureHeight);
        Color[] pixels = new Color[textureWidth * textureHeight];

        // Remplissage du fond
        for (int i = 0; i < pixels.Length; i++)
            pixels[i] = backgroundColor;

        // Dessin de la waveform
        for (int x = 0; x < textureWidth; x++)
        {
            int sampleIndex = (int)((x / (float)textureWidth) * samplesCount);
            float sampleValue = Mathf.Abs(samples[sampleIndex]); // Amplitude
            int height = (int)(sampleValue * (textureHeight / 2)); // Mise à l'échelle

            for (int y = (textureHeight / 2) - height; y < (textureHeight / 2) + height; y++)
            {
                pixels[y * textureWidth + x] = waveformColor;
            }
        }

        waveformTexture.SetPixels(pixels);
        waveformTexture.Apply();

        waveformImage.texture = waveformTexture;
    }
}
