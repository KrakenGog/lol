using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogsDictinory : MonoBehaviour
{
    public static Dictionary<string, List<Dialog>> SortDialogs = new Dictionary<string, List<Dialog>>();
    private void Start()
    {
        SortDialogs.Add("Informator", AllNpcDialogs.Informator);
        SortDialogs.Add("Lesha", AllNpcDialogs.Lesha);
        SortDialogs.Add("Tim", AllNpcDialogs.Tim);
        SortDialogs.Add("GrebenEXE", AllNpcDialogs.GrebenEXE);
        SortDialogs.Add("Gleb", AllNpcDialogs.Gleb);
        SortDialogs.Add("Evgeni", AllNpcDialogs.Evgeni);
    }
}
