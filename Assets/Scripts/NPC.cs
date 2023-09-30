using UnityEngine;

public class NPC : MonoBehaviour
{
    //Character Name
    public string characterName;

    public string[] dialogues;

    //Rotina
    //Onde mora?
    //Onde trabalha?
    //Ciclo de andar

    //Dialogo

    //Velocidade para andar

    // Awake chamado quando o objeto é criado
    private void Awake()
    {
        Debug.Log("AWAKE");
    }

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("START");
    }

    private void Update()
    {
        Debug.Log("UPDATE");
    }

    private void OnDestroy()
    {
        Debug.Log("DESTROY");
    }
}