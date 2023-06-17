using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeds : Interactable
{
    QuestSystem qs;
    SeedFruit sf;

    public override void Interaction()
    {
        Debug.Log("seeds interacted");
        Debug.Log(sf.gameObject.name);
        if (qs.currentQuest == sf)
        {
            sf.hasSeed = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        qs = FindObjectOfType<QuestSystem>();
        sf = FindObjectOfType<SeedFruit>();
    }
}
