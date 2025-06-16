using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_dialogue : MonoBehaviour
{
    
    public float dialogueRange;

    public LayerMask playerLayer;

    public DialogueSettings dialogues;

    private List<string> sentences = new List<string>();
    
    private bool playerHit;


    private void Start()
    {
        GetNPCDialogues();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && playerHit == true)
        {
            DialogueControl.instance.Speak(sentences.ToArray());
        }
    }

    private void GetNPCDialogues()
    {
        //acessando a lista, com o numero que tem dentro dessa lista

        for(int i = 0; i < dialogues.dialogues.Count; i++)
        {
            sentences.Add(dialogues.dialogues[i].sentence.portuguese);
        }
    }

    private void FixedUpdate()
    {
        ShowDialogue();
    }

    private void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer);

        if (hit != null)
        {
            playerHit = true;
        }
        else
        {
            playerHit = false;
            return;
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }

}
