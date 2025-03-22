using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumLaserController : MonoBehaviour
{
    public MediumAnalyzer MediumAnalyzer;
    public LineRenderer LineRenderer;
    public Color trebleColor = Color.blue;
    public Color offColor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MediumAnalyzer.IsTrebleHit())
        {
            ActivateLaser(trebleColor);
        }
        else
        {
            DeactivateLaser();
        }
    }

    void ActivateLaser(Color color)
    {
        LineRenderer.startColor = color;
        LineRenderer.endColor = color;
        LineRenderer.enabled = true;
    }

    void DeactivateLaser()
    {
        LineRenderer.startColor = offColor;
        LineRenderer.endColor = offColor;
        LineRenderer.enabled = false;
    }
}
