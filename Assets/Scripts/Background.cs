using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // 배경 매터리얼
    public Material bgMaterial;
    // 스크롤속도
    public float scrollSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 1. 살아 있는 동안 계속 하고 싶다.
    // Update is called once per frame
    void Update()
    {
        // 2. 방향이 필요하다.
        Vector2 direction = Vector2.up;
        // 3. 스크롤을 하고 싶다. P = P0 + vt
        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
    }
}
