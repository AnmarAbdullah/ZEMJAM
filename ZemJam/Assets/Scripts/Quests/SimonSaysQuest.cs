using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysQuest : Quest
{
   public GameObject door;
    public override Quest RunQuest()
    {
        if (FindObjectOfType<Simonsays>().puzzleDone) 
        {
            door.SetActive(false);
            return nextQuest;
        }
        return this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
