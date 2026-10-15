using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Transformations/Color")]
public class TransformAction : ClickAction
{
    public override void Execute(GameObject target, GameObject actor)
    {
        if (target.TryGetComponent<ColorTransformable>(out var t))
            t.StartTransformation();
    }
}
