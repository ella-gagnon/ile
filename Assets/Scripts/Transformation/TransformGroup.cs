using UnityEngine;

public class TransformGroup : MonoBehaviour
{
    [SerializeField] private Transform root;

    public void Trigger()
    {
        if (root == null) { Debug.LogWarning($"{name}: no root assigned.", this); return; }
        Debug.Log("Looking for something to transform...");
        foreach (var t in root.GetComponentsInChildren<Transformable>(true))
            t.StartTransformation();
    }
}
