using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Open Dialogue")]
public class OpenDialogueAction : ClickAction
{
    public string outputString;

    public override void Execute(GameObject target, GameObject actor)
        => Debug.Log(outputString);
}
