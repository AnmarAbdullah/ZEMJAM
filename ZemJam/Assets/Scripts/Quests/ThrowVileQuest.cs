using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThrowVileQuest : Quest
{
    public bool questDone;
    public TextMeshProUGUI youWInText;

    public TextMeshProUGUI launch;

    public override Quest RunQuest()
    {
        if (questDone)
        {
            youWInText.gameObject.SetActive(true);
        }
        return this;
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
