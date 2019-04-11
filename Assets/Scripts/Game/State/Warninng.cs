using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warninng : State
{
    public override void Execute()
    {
        if(gameObject.GetComponent<Player>() != null)
        {
           transform.LookAt(gameObject.GetComponent<Player>().transform.position);
        }
        throw new System.NotImplementedException();
    }
}
