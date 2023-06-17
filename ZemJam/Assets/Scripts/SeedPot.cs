using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPot : Interactable
{
    SeedFruit sf;
     public  GameObject pre;
     public  GameObject post;

    public override void Interaction()
    {
        sf = FindObjectOfType<SeedFruit>();
        if (sf.hasSeed)
        {
            pre.SetActive(false);
            post.SetActive(true);
            sf.plantedSeed = true;
        }
    }
}
