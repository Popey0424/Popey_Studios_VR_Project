using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeManager : MonoBehaviour
{
    public List<ParticleSystem> SmokesThrowers = new List<ParticleSystem>();
    private bool isSmokeActive = false;


    private void Start()
    {
        foreach(ParticleSystem go in SmokesThrowers)
        {
            go.Stop();
        }
    }
    private void Update()
    {
        Debug.Log(isSmokeActive);
    }
    public void TurnOnOffSmoke()
    {
        

        if (!isSmokeActive)
        {
            foreach (ParticleSystem go in SmokesThrowers)
            {
                go.Play();
                isSmokeActive=true;
            }
        }
        else if (isSmokeActive)
        {
            foreach(ParticleSystem go in SmokesThrowers)
            {
                go.Stop(true, ParticleSystemStopBehavior.StopEmitting);
                isSmokeActive = false;
            }
        }
    }
}
