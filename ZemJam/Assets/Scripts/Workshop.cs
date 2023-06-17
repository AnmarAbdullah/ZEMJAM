using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop : Interactable
{
    public GameObject vile;
    public GameObject fruitOnHand;
    public GameObject fluidOnHand;

    public override void Interaction()
    {
        if(FindObjectOfType<QuestSystem>().currentQuest == FindObjectOfType<Combine>())
        {
            // play particle System
            vile.SetActive(true);
            fruitOnHand.SetActive(false);
            fluidOnHand.SetActive(false);
        }
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
