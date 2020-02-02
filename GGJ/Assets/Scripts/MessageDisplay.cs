using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;
using UnityEngine.UI;

public class MessageDisplay : MonoBehaviour
{
    public Transform npcConversation;
    public Transform playerConversation;
    bool male;

    Text playerText;
    Text npcName;
    Text npcText;

    Image NPCImage;

    public Sprite female1;
    public Sprite female2;
    public Sprite female3;
    public Sprite male1;
    public Sprite male2;

    string npcFirstName;
    string npcLastName;

	// Use this for initialization
	void Start ()
    {
        playerText = playerConversation.GetChild(0).GetChild(0).GetComponent<Text>();
        npcText = npcConversation.GetChild(0).GetChild(0).GetComponent<Text>();
        npcName = npcConversation.GetChild(2).GetChild(0).GetComponent<Text>();
        NPCImage = npcConversation.GetChild(1).GetComponent<Image>();
        SetNPCCharacter();
    }
    private void SetNPCCharacter()
    {
        int rand = Random.Range(0, 2);
        switch (rand)
        {
            case 0:
                male = true;
                break;
            case 1:
                male = false;
                break;
        }

        SetImage(male);
        SetName(male);
    }

    private void SetImage(bool male)
    {
        if (male)
        {
            if (Random.Range(1, 2) == 1)
                NPCImage.sprite = male1;
            else
                NPCImage.sprite = male2;
        }
        else
        {
            int rand = Random.Range(1, 3);
            switch (rand)
            {
                case 1:
                    NPCImage.sprite = female1;
                    break;
                case 2:
                    NPCImage.sprite = female2;
                    break;
                case 3:
                    NPCImage.sprite = female3;
                    break;
            }
        }
    }

    private void SetName(bool male)
    {
        int rand = Random.Range(1, 5);
        if (male)
        {
            switch (rand)
            {
                case 1:
                    npcFirstName = "Jack";
                    break;
                case 2:
                    npcFirstName = "Alex";
                    break;
                case 3:
                    npcFirstName = "Matt";
                    break;
                case 4:
                    npcFirstName = "James";
                    break;
                case 5:
                    npcFirstName = "John";
                    break;
            }
        }
        else
        {
            switch (rand)
            {
                case 1:
                    npcFirstName = "Tina";
                    break;
                case 2:
                    npcFirstName = "Ashley";
                    break;
                case 3:
                    npcFirstName = "Maria";
                    break;
                case 4:
                    npcFirstName = "Jane";
                    break;
                case 5:
                    npcFirstName = "Jo";
                    break;
            }
        }

        rand = Random.Range(1, 5);

        switch(rand)
        {
            case 1:
                npcLastName = "Smith";
                break;
            case 2:
                npcLastName = "Wright";
                break;
            case 3:
                npcLastName = "Tooke";
                break;
            case 4:
                npcLastName = "Johnson";
                break;
            case 5:
                npcLastName = "Williams";
                break;
        }

        npcName.text = npcFirstName + " " + npcLastName;
    }

    IEnumerator DoDialog(string playerMessage, string npcMessage, float seconds)
    {
        
        npcText.text = npcMessage;
        for (int i = 1; i <= npcMessage.Length; i++)
        {
            npcText.text = npcMessage.Substring(0, i);
            yield return null;
        }

        playerText.text = playerMessage;
        for (int i = 1; i <= playerMessage.Length; i++)
        {
            playerText.text = playerMessage.Substring(0, i);
            yield return null;
        }

        yield return new WaitForSeconds(seconds);
    }

    public void ShowDialogue(string playerMessage, string npcMessage, float seconds)
    {
        StartCoroutine(DoDialog(playerMessage, npcMessage, seconds));
    }
}