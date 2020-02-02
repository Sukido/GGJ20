using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conversationSetter : MonoBehaviour
{

    public GameObject playerImage;
    public GameObject NPCImage;
    public GameObject NPCtext;
    public GameObject Playertext;

    private string playerText;
    private string npcText;

    MessageDisplay messageBox;

    void Start()
    {
        messageBox = GameObject.Find("MessageHandler").GetComponent<MessageDisplay>();
        SetText();
        messageBox.ShowDialogue(playerText, npcText, 3.0f);
    }
    
    void SetText()
    {
        int rand = Random.Range(1, 6);
        
        switch(rand)
        {
            case 1:
                playerText = "Yes, I can absolutely do that for you. I'll do it as soon as I can.";
                break;
            case 2:
                playerText = "Of Course, I'll get on it right away!";
                break;
            case 3:
                playerText = "It might be a little difficult, but I think I can do it.";
                break;
            case 4:
                playerText = "Sure, I have a few orders in front of yours but I will do it when I can.";
                break;
            case 5:
                playerText = "You've come at a good time, I just finished my previous order!";
                break;
            case 6:
                playerText = "I have plenty of materials for that, I'll get it sent to you when it's complete!";
                break;

        }

        rand = Random.Range(1, 10);

        switch (rand)
        {
            case 1:
                npcText = "Hello, would you be able to fix my dagger for me? It's taken quite a beating.";
                break;
            case 2:
                npcText = "As soon as you can, would you be able to make a sword for me?";
                break;
            case 3:
                npcText = "I need an axe making as soon as possible, my current one is about to break!";
                break;
            case 4:
                npcText = "I appear to have misplaced my sword, can you make me another one? There's no rush.";
                break;
            case 5:
                npcText = "The chains in the dungeons have started to rust, can I request a new set of them?";
                break;
            case 6:
                npcText = "His Royal Highness requests a ceremonial axe for the upcoming coronation. It is of upmost priority and we would appreciate it completed with haste.";
                break;
            case 7:
                npcText = "I require a pickaxe for my journey back into the mines next week, would to be able to get one done by then?";
                break;
            case 8:
                npcText = "A bow is needed for the army, can it be completed in due time?";
                break;
            case 9:
                npcText = "One of our hunting crossbows has been destroyed, can you fix it for us?";
                break;
            case 10:
                npcText = "My longsword has become dull, would it be possible for a sharpen?";
                break;
        }
    }
}


/*
 * Player:
"Yes, I can absolutely do that for you. I'll do it as soon as I can."
"Of Course, I'll get on it right away!"
"It might be a little difficult, but I think I can do it."
"Sure, I have a few orders in front of yours but I will do it when I can."
"You've come at a good time, I just finished my previous order!"
"I have plenty of materials for that, I'll get it sent to you when it's complete!"

NPC
"Hello, would you be able to fix my dagger for me? It's taken quite a beating."
"As soon as you can, would you be able to make a sword for me?"
"I need an axe making as soon as possible, my current one is about to break!"
"I appear to have misplaced my sword, can you make me another one? There's no rush."
"The chains in the dungeons have started to rust, can I request a new set of them?"
"His Royal Highness requests a ceremonial axe for the upcoming coronation. It is of upmost priority and we would appreciate it completed with haste."
"I require a pickaxe for my journey back into the mines next week, would to be able to get one done by then?"
"A bow is needed for the army, can it be completed in due time?"
"One of our hunting crossbows has been destroyed, can you fix it for us?"
"My longsword has become dull, would it be possible for a sharpen?"
*/