using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class VariantInScene : MonoBehaviour,IPointerClickHandler
{
    public static event UnityAction<Answer> VariantPicked;
    public Answer Current;
    public void OnPointerClick(PointerEventData eventData)
    {
        VariantPicked?.Invoke(Current);
    }
    public void Clear()
    {
        Destroy(gameObject);
    }
}
