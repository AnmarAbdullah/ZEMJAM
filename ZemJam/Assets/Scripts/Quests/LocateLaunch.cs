using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocateLaunch : Quest
{
    public override Quest RunQuest()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            if(hit.collider.tag == "Launch")
            {
                return nextQuest;
            }
        }
        return this;
    }
}
