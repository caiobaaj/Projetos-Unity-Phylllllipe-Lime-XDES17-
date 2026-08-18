using UnityEngine;

public class ScrollBgAula3 : MonoBehaviour
{
    [SerializeField] private float velocidade;
    
    private Material _bgMaterial;
    private Vector2 _offset;
    private float _offsetX;
    
    void Awake()
    {
        _bgMaterial = GetComponent<SpriteRenderer>().material;
    }
    
    void Update()
    {
        _offsetX += velocidade * Time.deltaTime;
        _offset.x = _offsetX;
        _bgMaterial.mainTextureOffset = _offset;
    }
}
