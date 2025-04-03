using UnityEngine;
using MidiJack;

public class MidiButtonTest : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < 128; i++) 
        {
            if (MidiMaster.GetKeyDown(i))
            {
                Debug.Log($"Button {i} Pressed!");
            }
            if (MidiMaster.GetKeyUp(i))
            {
                Debug.Log($"Button {i} Released!");
            }
        }
    }
}