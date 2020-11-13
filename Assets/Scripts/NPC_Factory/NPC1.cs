using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC1 : NPC
{    
    public override string name { get; set; }
    public override GameObject gameObject { get; set; }
    public override string[] fluffTextConversations { get; set; }
    public override bool goBack { get; set; }    
    public override GameObject pos1 { get { return Pos1; } set {  Pos1 = value; } }    
    public override GameObject pos2 { get { return Pos2; } set { Pos2 = value; } }
    [SerializeField]
    GameObject Pos1;
    [SerializeField]
    GameObject Pos2;

    NavMeshAgent navMeshAgent;


    public void Start()
    {
        #region
        gameObject = GameObject.FindGameObjectWithTag(Types.npc1.ToString());
        navMeshAgent = this.GetComponent<NavMeshAgent>();
        goBack = false;
        #endregion        
    }

    public override void TalkTO(string type)
    {    
        throw new System.NotImplementedException();
    }

    public override void SetDestination(Transform _destination)
    {
        if(_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            navMeshAgent.SetDestination(targetVector);
            //if (navMeshAgent.pathStatus == NavMeshPathStatus.PathComplete)
            //{
            //    SetDestination(pos2.transform);
            //    goBack = !goBack;
            //}
                
            

        }
    }
        
    private void Update()
    {
        try
        {
            Patrol();
            if (gameObject.transform.position == pos1.transform.position)
                Debug.Log("hi");
        }
        catch (System.Exception ex)
        {
            Debug.LogError(ex);
        }
    }
}
