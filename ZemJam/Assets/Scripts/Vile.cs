using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vile : Interactable
{
    public GameObject vileOnHand;
    public GameObject vileOnScene;
    public override void Interaction()
    {
        vileOnHand.SetActive(true);
        vileOnScene.SetActive(false);
        FindObjectOfType<Combine>().combineDone = true;
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
