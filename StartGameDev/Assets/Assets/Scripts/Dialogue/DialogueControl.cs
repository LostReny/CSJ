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
    private int index; //usado para laço de repetição - quantidade de texto dentro de uma fala

    private string[] sentences;

    //singleton?
    public static DialogueControl instance;

    //awake é chamado antes de qq start
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
    }


    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray()) 
        {
            speakText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }   
    }

    public void NextSentence()
    {

    }

    public void Speak(string[] txt)
    {
        if (!isShowing)
        {
            dialogueObject.SetActive(true);
            sentences = txt;
            StartCoroutine("TypeSentence");

            isShowing = true;
        }
    }

}
