using UnityEngine;

public class BassLaserController : MonoBehaviour
{
    public BassAnalyzer audioAnalyzer;

    public LineRenderer lineRenderer;
    public Color laserColorOn = Color.red;
    public Color laserColorOff = Color.black;

    void Update()
    {
        if (audioAnalyzer.IsBassHit())
        {
            ActivateLaser();
        }
        else
        {
            DeactivateLaser();
        }
    }

    void ActivateLaser()
    {
        lineRenderer.startColor = laserColorOn;
        lineRenderer.endColor = laserColorOn;
        lineRenderer.enabled = true;
    }

    void DeactivateLaser()
    {
        lineRenderer.startColor = laserColorOff;
        lineRenderer.endColor = laserColorOff;
        lineRenderer.enabled = false;
    }
}