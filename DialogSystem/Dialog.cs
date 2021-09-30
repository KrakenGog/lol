using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog 
{
    public int DialogIndex;
    public DialogAct[] DialogStruct;

    public Dialog(int index,DialogAct[] act)
    {
        DialogIndex = index;
        DialogStruct = act;
    }
}

