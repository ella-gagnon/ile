using UnityEngine;

public abstract class ClickAction : ScriptableObject
{
    public abstract void Execute(GameObject target, GameObject actor);
}
