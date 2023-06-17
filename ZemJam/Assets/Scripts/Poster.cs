using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : Interactable
{
    public GameObject dust;
    public GameObject uiOfCode;
    public GameObject vileonhand;

    public override void Interaction()
    {
        if(FindObjectOfType<QuestSystem>().currentQuest == FindObjectOfType<ThrowVileQuest>())
        {
            dust.SetActive(false);
            vileonhand.SetActive(false);
            uiOfCode.SetActive(true);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
