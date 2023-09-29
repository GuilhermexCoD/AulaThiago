using System;
using TMPro;
using UnityEngine;

public class DialogueNameUI : MonoBehaviour
{
    public NPC npc;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    private int dialogueIndex = 0;

    // Start is called before the first frame update
    private void Start()
    {
        AtualizarDialogo();
    }

    public void AtualizarDialogo()
    {
        nameText.text = npc.characterName;
        dialogueText.text = GetDialogueByIndex(dialogueIndex);
    }

    public string GetDialogueByIndex(int index)
    {
        string dialogue = "";

        if (index < npc.dialogues.Length)
        {
            dialogue = npc.dialogues[index];
        }
        else
        {
            dialogue = "Não tenho mais nada para dizer";
        }

        return dialogue;
    }

    public void NextDialogue()
    {
        dialogueIndex += 1;
        AtualizarDialogo();
    }
}