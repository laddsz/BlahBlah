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
        // �p��s�� Y �b����
        offsetY += scrollSpeed * Time.deltaTime;

        // �N Y �b�������Ψ���誺 offset �W
        material.SetTextureOffset("_MainTex", new Vector2(0, offsetY));
    }
}
