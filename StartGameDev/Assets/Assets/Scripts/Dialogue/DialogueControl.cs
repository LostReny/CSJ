using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObject; //janela do dialogo
    public Image profileSprite; //sprite do perfil
    public Text speakText; // texto da fala
    public Text actorNameText; // nome do NPC

    [Header("Settings")]
    public float typingSpeed; // velocidade da fala

    // variaveis de controle
    private bool isShowing; //se janela está visivel
                         

}
