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
    public new abstract string name { get; set; }
    public new abstract GameObject gameObject { get; set; }
    public abstract GameObject pos1 { get; set; }
    public abstract GameObject pos2 { get; set; }
    public abstract bool goBack { get; set; }
    public abstract string[] fluffTextConversations { get; set; }

    public string RandomDialogue(string [] dialogueChoices)
    {
        string output = "";

        return output;
    }

    public abstract void SetDestination(Transform _destination);

    public void Patrol()
    {
        if(goBack == false)
        {
            SetDestination(pos1.transform);
           
        }        
        else if(goBack == true)
        {
            SetDestination(pos2.transform);            
        }
    }

    public abstract void TalkTO(string type); 
        
}
