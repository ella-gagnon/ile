using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteTransformable : MonoBehaviour, Transformable
{
    public Sprite initialSprite;
    public Sprite finalSprite;

    private SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = initialSprite;
    }

    public void StartTransformation()
    {
        Debug.Log("Transforming...");
        sr.sprite = finalSprite;
    }
}
