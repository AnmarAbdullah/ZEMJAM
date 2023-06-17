using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBucketQuest : Quest
{
    public GameObject BucketOnHand;
    public GameObject BucketOnScene;
    public bool questDone;
    public override Quest RunQuest()
    {
        if (questDone)
        {
            BucketOnHand.SetActive(true);
            BucketOnScene.SetActive(false);
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
