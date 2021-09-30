using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogPresenter : MonoBehaviour
{
    public static event UnityAction OnEnded;
    [SerializeField] private GameObject DialogSystemUI;
    [SerializeField] private Transform VariantsParent;
    [SerializeField] private Text MainTextField;
    [SerializeField] private Text NpcName;
    [SerializeField] private GameObject VariantPrefab;
    private Dialog current;
    private DialogAct currentAct;
    
    public void StartDialog(Dialog dialog,string npcName)
    {
        NpcName.text = npcName;
        ClearAnswers();
        DialogSystemUI.SetActive(true);
        current = dialog;
        StartAct(current.DialogStruct[0]);
    }
    private void StartAct(DialogAct act)
    {
        PixelWrite(act.Tesis);
        currentAct = act;
    }
    public void PixelWrite(string text)
    {
        StartCoroutine(PixelWriteTime(text));
    }
    private void ClearAnswers()
    {
        foreach (var item in VariantsParent.GetComponentsInChildren<VariantInScene>())
        {
            item.Clear();
        }
    }
    private void VariantsPresenter()
    {
        
        foreach (var item in currentAct.Answers)
        {
            GameObject inst = Instantiate(VariantPrefab);

            inst.GetComponentInChildren<Text>().text = item.Saying;
            inst.GetComponent<VariantInScene>().Current = item;
            inst.transform.SetParent(VariantsParent);
            inst.transform.localScale = Vector3.one;
        }
    }
    IEnumerator PixelWriteTime(string text)
    {
        MainTextField.text = "";
        foreach (var item in text.ToCharArray())
        {
            MainTextField.text += item;
            yield return new WaitForSeconds(0.01f);
        }

        VariantsPresenter();
    }
    private void Exit()
    {
        OnEnded?.Invoke();
        DialogSystemUI.SetActive(false);
    }
    public void VariantPicker(Answer picked)
    {
        Answer.Active(picked.Context);
        if (picked.nextActIndex == -1)
        {
            Exit();
            return;
        }
        ClearAnswers();
        StartAct(current.DialogStruct[picked.nextActIndex]);
    }
    private void OnEnable()
    {
        VariantInScene.VariantPicked += VariantPicker;
    }
    private void OnDestroy()
    {
        VariantInScene.VariantPicked -= VariantPicker;
    }
}
