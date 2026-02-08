using UnityEngine;
using UnityEngine.EventSystems;

public class HoldAnimatorButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator targetAnimator;
    public string parameterName = "Active";

    public void OnPointerDown(PointerEventData eventData)
    {
        targetAnimator.SetBool(parameterName, true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        targetAnimator.SetBool(parameterName, false);
    }
}