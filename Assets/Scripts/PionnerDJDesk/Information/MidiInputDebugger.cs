//using MidiJack;
//using UnityEngine;

//public class MidiDeviceDebugger : MonoBehaviour
//{
//    void Start()
//    {
//        Debug.Log("?? Liste des périphériques MIDI détectés :");

//        for (int i = 0; i < 4; i++) // MidiJack supporte jusqu'à 4 périphériques
//        {
//            string deviceName = MidiMaster.GetDeviceName(i);
//            if (!string.IsNullOrEmpty(deviceName))
//            {
//                Debug.Log($"??? Périphérique {i}: {deviceName}");
//            }
//        }
//    }
//}