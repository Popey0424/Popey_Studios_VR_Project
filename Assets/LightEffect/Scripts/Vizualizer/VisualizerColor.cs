using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualizerColor : MonoBehaviour
{

    public Image Image;
    public void SetColor(float frequency)
    {
        if(frequency < 200)
        {
            Image.color = Color.red;
        }
        else if(frequency < 2000)
        {
            Image.color = Color.green;
        }
        else
        {
            Image.color = Color.blue;
        }
    }
}
