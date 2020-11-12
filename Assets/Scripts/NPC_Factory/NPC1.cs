using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : NPC
{    
    public override string Name { get; set; }
    public override GameObject gameObject { get; set; }

    public void Start()
    {
        gameObject = GameObject.FindGameObjectWithTag(Types.npc1.ToString());
    }

    public override void TalkTO(string type)
    {    
        throw new System.NotImplementedException();
    }

    public override void WalkTo()
    {
        
        throw new System.NotImplementedException();
        
    }
    
}
