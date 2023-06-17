using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Codex : Interactable
{
    public int chosenNumber;
    [SerializeField] TextMeshProUGUI numberText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numberText.text = chosenNumber.ToString();
    }

    public override void Interaction()
    {
        chosenNumber++;
        if (chosenNumber > 9) chosenNumber = 0;
    }
}
