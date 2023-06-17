using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LaunchCode : Interactable
{
    [SerializeField] int[] correctCode;
    [SerializeField] int[] inputtedCode = new int[4];
    [SerializeField] Codex[] codex;
    [SerializeField] TextMeshProUGUI[] texts;
    void Start()
    {
        for (int i = 0; i < correctCode.Length; i++)
        {
            correctCode[i] = Random.Range(0, 10);
            texts[i].text = correctCode[i].ToString();
        }
        for (int i = 0;i < inputtedCode.Length; i++)
        {
            inputtedCode[i] = codex[i].chosenNumber;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < inputtedCode.Length; i++)
        {
            inputtedCode[i] = codex[i].chosenNumber;
        }
    }

    public override void Interaction()
    {
        bool correct = false;

        for (int i = 0; i < inputtedCode.Length; i++)
        {
            if (inputtedCode[i] == correctCode[i])
            {
                correct = true;
                FindObjectOfType<ThrowVileQuest>().questDone = true;
            } 
            else { correct = false; Debug.Log("Found error"); break; }
        }

        if (correct) Debug.Log("Code Correct");
        /*if (inputtedCode == correctCode)
        {
            // win condition here...
            Debug.Log("Code Correct");
        }
        else
        {
            // loss condition here...
            Debug.Log("Code Wrong");
        }   */
    }
}
