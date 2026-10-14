using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Transform")]
public class TransformAction: ClickAction
{
    public Transformable obj;

    public override void Execute(GameObject target, GameObject actor)
    => obj.startTransformation();
}
