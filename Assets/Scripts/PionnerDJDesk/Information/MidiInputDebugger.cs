//using MidiJack;
//using UnityEngine;

//public class MidiDeviceDebugger : MonoBehaviour
//{
//    void Start()
//    {
//        Debug.Log("?? Liste des p�riph�riques MIDI d�tect�s :");

//        for (int i = 0; i < 4; i++) // MidiJack supporte jusqu'� 4 p�riph�riques
//        {
//            string deviceName = MidiMaster.GetDeviceName(i);
//            if (!string.IsNullOrEmpty(deviceName))
//            {
//                Debug.Log($"??? P�riph�rique {i}: {deviceName}");
//            }
//        }
//    }
//}