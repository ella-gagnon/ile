using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Transformations/Group")]
public class GroupTransformAction : ClickAction
{
    public override void Execute(GameObject target, GameObject actor)
    {
        if (target.TryGetComponent<TransformGroup>(out var g))
            g.Trigger();
        else
            Debug.LogWarning($"{target.name} has no TransformGroup.", target);
    }
}
