using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class Answer
{
    public static event UnityAction<string> OnImportantAnswer;

    public string Saying;
    public string Context;
    public int nextActIndex;

    public Answer(string saying, string context, int index)
    {
        Saying = saying;
        Context = context;
        nextActIndex = index;
    }

    public static void Active(string context)
    {
        OnImportantAnswer?.Invoke(context);
    }
}
