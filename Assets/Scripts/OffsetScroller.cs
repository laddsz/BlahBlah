using UnityEngine;

public class OffsetScroller : MonoBehaviour
{
    public Material material;
    public float scrollSpeed = 0.5f;
    private float offsetY;

    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }
    void Update()
    {        
        // 計算新的 Y 軸偏移
        offsetY += scrollSpeed * Time.deltaTime;

        // 將 Y 軸偏移應用到材質的 offset 上
        material.SetTextureOffset("_MainTex", new Vector2(0, offsetY));
    }
}
