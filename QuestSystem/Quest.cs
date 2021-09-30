using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    private string _name;
    private string _npcName;
    private int _plotIndex;
    private string _questDiscription;

    public string Name => _name;
    public string NpcName => _npcName;
    public string QuestDiscription => _questDiscription;
    public int PlotIndex => _plotIndex;

    public Quest(string name,string ncpName,int plot,string discr)
    {
        _name = name;
        _npcName = ncpName;
        _plotIndex = plot;
        _questDiscription = discr;
    }

    public void Active()
    {
        PlayerPrefs.SetInt(_npcName+"CurrentDialogIndex", PlayerPrefs.GetInt(_npcName+"CurrentDialogIndex")+1);
    }
}
