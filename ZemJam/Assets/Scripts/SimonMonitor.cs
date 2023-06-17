using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonMonitor : Interactable
{
    [SerializeField] public RawImage mySymbol;
    [SerializeField] public int myID;
    Simonsays ss;

    private void Start()
    {
        ss = FindObjectOfType<Simonsays>();
    }

    public override void Interaction()
    {
        ss.answergiven = true;
        ss.chosenNumber = myID;
    }

}
