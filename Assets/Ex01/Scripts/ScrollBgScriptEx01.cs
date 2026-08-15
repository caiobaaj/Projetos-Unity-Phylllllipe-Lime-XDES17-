using UnityEngine;

public class ScrollBgScriptEx01 : MonoBehaviour
{
    [SerializeField] private float velocidade;
    
    private Material _bgMaterial;
    private Vector2 _offset;
    private float _offsetY;
    
    void Awake()
    {
        _bgMaterial = GetComponent<SpriteRenderer>().material;
    }
    
    void Update()
    {
        _offsetY += velocidade * Time.deltaTime;
        _offset.y = _offsetY;
        _bgMaterial.mainTextureOffset = _offset;
    }
}
