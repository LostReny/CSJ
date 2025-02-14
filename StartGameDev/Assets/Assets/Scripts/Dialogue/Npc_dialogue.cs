using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_dialogue : MonoBehaviour
{
    public float dialogueRange;

    public LayerMask playerLayer;


    private void FixedUpdate()
    {
        ShowDialogue();
    }

    private void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer);

        if (hit != null)
        {
            Debug.Log("colisão");
        }
        else
        {
            return;
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }

}
