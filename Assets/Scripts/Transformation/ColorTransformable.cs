using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorTransformable : MonoBehaviour, Transformable
{
    public Color deadColor = Color.gray;
    public Color liveColor = Color.white;
    public float duration = 1f;

    private SpriteRenderer spriteRenderer;
    private Coroutine running;

    void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = deadColor;
    }

    public void StartTransformation() {
       if (running != null) StopCoroutine(running);
       running = StartCoroutine(Fade(spriteRenderer.color, liveColor));
    }

    private IEnumerator Fade(Color from, Color to)
        {
            for (float t = 0f; t < duration; t += Time.deltaTime)
            {
                spriteRenderer.color = Color.Lerp(from, to, t / duration);
                yield return null; // wait one frame
            }
            spriteRenderer.color = to;
            running = null;
    }
}
