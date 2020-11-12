using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Types
{
    npc1,
    npc2
}
public abstract class NPC : MonoBehaviour
{    
    public abstract string Name { get; set; }
    public abstract GameObject gameObject { get; set; }

    public string RandomDialogue(string [] dialogueChoices)
    {
        string output = "";

        return output;
    }

    public abstract void WalkTo();

    public abstract void TalkTO(string type); 
        
}
