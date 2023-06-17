using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Interactable
{
    QuestSystem qs;
    SeedFruit sf;

    public override void Interaction()
    {
        sf.hasFruit = true;
    }

    void Start()
    {
        qs = FindObjectOfType<QuestSystem>();
        sf = FindObjectOfType<SeedFruit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
