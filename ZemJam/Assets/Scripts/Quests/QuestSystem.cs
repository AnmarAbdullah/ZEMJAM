using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestSystem : MonoBehaviour
{
    public Quest currentQuest;
    public TextMeshProUGUI currentQuestInfoText;

    void Update()
    {
        Quest runQuest = currentQuest.RunQuest();
        if(runQuest != null)
        {
            currentQuest = runQuest;
        }
        currentQuestInfoText.text = "Current Objective:\n" + runQuest.ObjectiveText;
    }
}
