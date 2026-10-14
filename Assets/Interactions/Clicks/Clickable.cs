using UnityEngine;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour, IPointerClickHandler
{
    public ClickAction action; // drag any action asset in here

    public void OnPointerClick(PointerEventData e)
        => action?.Execute(gameObject, gameObject); // placeholder actor until you have a player
}
