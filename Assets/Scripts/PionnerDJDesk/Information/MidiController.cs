using UnityEngine;
using MidiJack;

public class MidiController : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < 128; i++) 
        {
            float value = MidiMaster.GetKnob(i, 0);
            if (value > 0)
            {
                Debug.Log("MIDI Input " + i + " : " + value);
            }
        }
    }
}