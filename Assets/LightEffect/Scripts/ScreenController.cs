using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    public ScreenAnalyzer screenAnalyzer;
    public MeshRenderer meshRenderer;
    public Color BassColor = Color.red;
    public Color MediumColor = Color.yellow;

    public Color OffColor = Color.black;
   
    void Start()
    {
        
    }


    void Update()
    {
        if (screenAnalyzer.IsBassHit())
        {
            ActivateScreen(BassColor);
        }
        else if (screenAnalyzer.IsTrebleHit())
        {
            ActivateScreen(MediumColor);
        }
    }


    private void ActivateScreen(Color color)
    {

        meshRenderer.material.color = color;
        meshRenderer.enabled = true;
    }

    private void DeactivateScreen()
    {
        meshRenderer.material.color = OffColor;
        meshRenderer.enabled = false;
    }
}
