using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Quest : MonoBehaviour
{
    public Quest nextQuest;
    public string ObjectiveText;
    public abstract Quest RunQuest();
}
