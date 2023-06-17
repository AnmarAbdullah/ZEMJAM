using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : Quest
{
    public bool combineDone;
    public override Quest RunQuest()
    {
        if (combineDone)
        {
            return nextQuest;
        }
        return this;
    }

}
