using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateManager : MonoBehaviour
{
    [Tooltip("Qual o FPS alvo do nosso jogo.")]
    public int frameRateTarget;

    //Apenas configurei o Target Frame Rate para explicacao
    //Chamada antes de todos os metodos da Unity 
    //Chamada ante do metodo Start
    private void Awake()
    {
        Application.targetFrameRate = frameRateTarget;
    }
}
