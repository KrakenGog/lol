using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAct : MonoBehaviour
{
    public string Tesis;
    public Answer[] Answers;

    public DialogAct(string tesis, Answer[] answers)
    {
        Tesis = tesis;
        Answers = answers;
    }
}
