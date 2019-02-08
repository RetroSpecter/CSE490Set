using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodRayFader : MonoBehaviour
{

    public Vector2 fadeRange;
    public Vector2 speedRange;
    public Vector2 sizeRange;

    float speed;
    private MeshRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();

        Vector3 scale = transform.localScale;
        scale.z = Random.Range(sizeRange.x, sizeRange.y);
        transform.localScale = scale;

        speed = Random.Range(speedRange.x, speedRange.y);

        float targetAlpha = Random.Range(fadeRange.x, fadeRange.y);
        Color c = renderer.material.color;
        c.a = targetAlpha;
        renderer.material.color = c;
    }
}
