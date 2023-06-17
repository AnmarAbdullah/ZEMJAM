using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Simonsays : Interactable
{
    [SerializeField] SimonMonitor[] simons;
  
    int index; // show this with text;

    public int chosenNumber;

    public List<int> appliedNums;

    bool puzzleStarted;
    public bool puzzleDone;
    bool begin;
    public bool answergiven;

    float timer;



    void Start()
    {

    }

    public int chosenIndex;
    public RawImage findThisImage;
    public TextMeshProUGUI progressText;

    void Update()
    {
        if (!puzzleDone)
        {
            if (puzzleStarted)
            {
                chosenIndex = Random.Range(0, simons.Length);
                findThisImage.texture = simons[chosenIndex].mySymbol.texture;
                puzzleStarted = false;
            }

            progressText.text = $"{index} / 5";

            if (answergiven)
            {
                if (chosenNumber == simons[chosenIndex].myID)
                {
                    if (index >= 5)
                    {
                        endPuzzle();
                    }
                    findThisImage.texture = null;
                    puzzleStarted = true;
                    index++;
                    answergiven = false;
                    Debug.Log("ur mom");
                }
                else
                {
                    // wee woo wee woo wee woo
                    Debug.Log("you suck");
                    index = 0;
                }
            }
        }
        if (puzzleDone) {
            index++;
            index--;
        } 
        
    }

    public override void Interaction()
    {
        if (!begin && FindObjectOfType<QuestSystem>().currentQuest == FindObjectOfType<SimonSaysQuest>())
        {
            puzzleStarted = true;
            begin = true;
        }
    }

    public void endPuzzle() 
    {
        puzzleDone = true;
        puzzleStarted = false;
        //go to enxt quest
        Debug.Log("puzzle ended");
    }
}
