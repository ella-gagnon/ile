using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Trigger Transform Group")]
public class GroupTransformAction : ClickAction
{
    public override void Execute(GameObject target, GameObject actor)
    {
        if (target.TryGetComponent<TransformGroup>(out var g))
            g.Trigger();
    }
}
