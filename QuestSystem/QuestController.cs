using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    public void ActiveQuest(string name)
    {

    }

    private void OnEnable()
    {
        Answer.OnImportantAnswer += ActiveQuest;
    }
    private void OnDisable()
    {

        Answer.OnImportantAnswer -= ActiveQuest;
    }
}
