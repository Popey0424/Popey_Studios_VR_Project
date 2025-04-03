using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(SpriteRenderer))]
public class Track : MonoBehaviour
{
    public int width = 1024;
    public int height = 64;
    public Color background = Color.black;
    public Color foreground = Color.yellow;
    public GameObject arrow = null;
    //public Camera cam = null;

    private AudioSource aud = null;
    private SpriteRenderer sprend = null;
    private int samplesize;
    private float[] samples = null;
    private float[] waveform = null;
    private float arrowoffsetx;

    private void Start()
    {
        {
            // Reference components on the GameObject
            aud = this.GetComponent<AudioSource>();
            sprend = this.GetComponent<SpriteRenderer>();

            Texture2D texwav = GetWaveform();
            Rect rect = new Rect(Vector2.zero, new Vector2(width, height));
            sprend.sprite = Sprite.Create(texwav, rect, new Vector2(0.0f, 0.5f)); // Centrer sur Y

            // Attends que Unity mette à jour la taille du Sprite
            StartCoroutine(InitializeArrowPosition());
        }
    }

    private void Update()
    {
        if (aud.clip != null && aud.clip.length > 0)
        {
            float progress = aud.time / aud.clip.length; // Proportion du temps écoulé
            float xoffset = progress * sprend.bounds.size.x; // Taille réelle de la waveform

            // Correction du Z en récupérant la position originale de l'arrow
            Vector3 arrowPosition = arrow.transform.position;
            arrow.transform.position = new Vector3(sprend.bounds.min.x + xoffset, transform.position.y, arrowPosition.z);
        }
    }
    private Texture2D GetWaveform()
    {
        int halfheight = height / 2;
        float heightscale = (float)height * 0.75f;

        // get the sound data
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGBA32, false);
        waveform = new float[width];

        samplesize = aud.clip.samples * aud.clip.channels;
        samples = new float[samplesize];
        aud.clip.GetData(samples, 0);

        int packsize = (samplesize / width);
        for (int w = 0; w < width; w++)
        {
            waveform[w] = Mathf.Abs(samples[w * packsize]);
        }

        // map the sound data to texture
        // 1 - clear
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                tex.SetPixel(x, y, background);
            }
        }

        // 2 - plot
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < waveform[x] * heightscale; y++)
            {
                tex.SetPixel(x, halfheight + y, foreground);
                tex.SetPixel(x, halfheight - y, foreground);
            }
        }

        tex.Apply();

        return tex;
    }

    private IEnumerator InitializeArrowPosition()
    {
        yield return new WaitForEndOfFrame(); // Attends une frame pour que le sprite soit bien initialisé

        // Correction du Z en gardant la valeur initiale
        Vector3 arrowPosition = arrow.transform.position;
        arrow.transform.position = new Vector3(sprend.bounds.min.x, transform.position.y, arrowPosition.z);
    }
}