using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingTexture : MonoBehaviour
{
    public float scrollSpeedX = 0.5f;
    public float scrollSpeedY = 0.5f;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.time * scrollSpeedX;

        float offsetY = Time.time *scrollSpeedY;

        rend.material.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
    }
}
