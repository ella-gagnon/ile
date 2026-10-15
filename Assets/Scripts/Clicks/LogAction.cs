using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Text/Log")]
public class LogAction : ClickAction
{
    public string outputString;

    public override void Execute(GameObject target, GameObject actor)
        => Debug.Log(outputString);
}
