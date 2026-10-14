using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class WorldBorder : MonoBehaviour
{
    void Awake()
    {
        Bounds b = GetComponent<SpriteRenderer>().bounds; // world space
        Vector2 bl = transform.InverseTransformPoint(new Vector2(b.min.x, b.min.y));
        Vector2 tl = transform.InverseTransformPoint(new Vector2(b.min.x, b.max.y));
        Vector2 tr = transform.InverseTransformPoint(new Vector2(b.max.x, b.max.y));
        Vector2 br = transform.InverseTransformPoint(new Vector2(b.max.x, b.min.y));

        var edge = gameObject.AddComponent<EdgeCollider2D>();
        edge.points = new[] { bl, tl, tr, br, bl };
    }
}
