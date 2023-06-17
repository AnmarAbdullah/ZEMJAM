using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedFruit : Quest
{
    public bool hasSeed;
    public bool plantedSeed;
    public bool hasFruit;

    public GameObject fruitOnHand;
    public GameObject fruitOnScene;
    public GameObject seedOnPot;
    public GameObject seedOnScene;
    public GameObject seedsOnHand;
    public GameObject bigPlantOnPresent;

    public override Quest RunQuest()
    {
        if (hasSeed)
        {
            seedsOnHand.SetActive(true);
            seedOnScene.SetActive(false);
        }
        if (plantedSeed)
        {
            seedOnPot.SetActive(true);
            seedsOnHand.SetActive(false);
            bigPlantOnPresent.SetActive(true);
        }

        if (hasFruit)
        {
            fruitOnHand.SetActive(true);
            fruitOnScene.SetActive(false);
            return nextQuest;
        }
        return this;
    }
}
