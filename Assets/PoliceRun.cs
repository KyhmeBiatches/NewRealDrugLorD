using UnityEngine;
using System.Collections;

public class PoliceRun : MonoBehaviour {

    private AIFollow PolicemenFollow;
    private AIPath PolicemenPatrol;
    public 
    
	// Use this for initialization
	void Start () {
        PolicemenFollow = GameObject.FindGameObjectWithTag("Five-0").GetComponent<AIFollow>();
        PolicemenPatrol = GameObject.FindGameObjectWithTag("Five-0").GetComponent<AIPath>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CatchMainPerson()
    {
        GameObject player = GameObject.FindGameObjectWithTag("MainPerson");
        PolicemenPatrol.OnDisable();
        PolicemenFollow.target = player.transform;
    }

    public void ThatGuy()
    {
        
    }

    public void GiveFine()
    {

    }
}
