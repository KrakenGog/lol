using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialog : IAction
{
    
    [SerializeField] private string NpcName;
    [SerializeField] private DialogPresenter DialogPresenter;
    private NpcBehavior _npcBehavior;
    private void Start()
    {
        _npcBehavior = GetComponent<NpcBehavior>();
    }
    public override void Active()
    {
        _npcBehavior.Stop();
        int currentIndex = PlayerPrefs.GetInt(NpcName+"CurrentDialogIndex");
        List<Dialog> currentDialogList = DialogsDictinory.SortDialogs[NpcName];
        foreach (var item in currentDialogList)
        {
            if(item.DialogIndex==currentIndex)
            {
                DialogPresenter.StartDialog(item,NpcName);
                break;
            }
        }
    }
}
