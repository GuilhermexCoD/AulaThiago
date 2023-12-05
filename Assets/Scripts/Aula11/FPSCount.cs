using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCount : MonoBehaviour
{
    public int frameCount = 0;

    private float tempoInicial;
    private float tempoFinal;
    private float intervaloTempo;
    private void Update()
    {
        tempoFinal = Time.time;

        intervaloTempo = tempoFinal - tempoInicial;

        frameCount++;
        //frameCount = frameCount + 1;
        //frameCount += 1;
        // Frame Count = {frameCount}
        Debug.Log($"Frame Count = {frameCount} | Time = {Time.time} | Delta Time = {intervaloTempo}" );
        //Debug.Log("Frame Count = " + frameCount);
        //Debug.Log(string.Concat("Frame Count = ", frameCount));

        tempoInicial = Time.time;
    }
}
