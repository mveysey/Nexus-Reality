using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BestFriend : MonoBehaviour
{
    public TextMeshProUGUI dialogueDisplay;
    public GameObject dialogue;
    public GameObject button;
    public GameObject continueButton;

    [TextArea(3, 30)]
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public void StartDialogue()
    {
        dialogue.SetActive(true);
        StartCoroutine(Type());
    }

    public void Update()
    {
        if (dialogueDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    public void HideButton()
    {
        button.SetActive(false);
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            dialogueDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            dialogueDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            dialogueDisplay.text = "";
            dialogue.SetActive(false);
            button.SetActive(true);
            SceneManager.LoadScene("Basketball");
        }
    }
}
