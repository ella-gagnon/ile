using UnityEngine;

public class TransformGroup : MonoBehaviour
{
    [SerializeField] private Transform root;

    public void Trigger()
    {
        if (root == null) { Debug.LogWarning($"{name}: no root assigned.", this); return; }

        foreach (var t in root.GetComponentsInChildren<ColorTransformable>(true))
            t.StartTransformation();
    }
}
