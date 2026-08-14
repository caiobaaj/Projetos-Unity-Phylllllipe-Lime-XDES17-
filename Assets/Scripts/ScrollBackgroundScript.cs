using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScrollBackgroundScript : MonoBehaviour
{
    [SerializeField] private GameObject backgroundPrefab;
    [SerializeField] private List<Sprite> backgrounds = new List<Sprite>(6);
    [SerializeField] private float speed = 0.01f;
    
    private int _i;
    private SpriteRenderer _sr;
    private bool _hasUpdated = false;
    
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        RandomIndex();
        _sr.sprite = backgrounds[_i];
    }

    void Update()
    {
        if (transform.position.x <= 0 && !_hasUpdated)
        {
            _hasUpdated = true;
            Instantiate(backgroundPrefab, new Vector3(8.88889f*2, 0, 0), Quaternion.identity);
        }

        transform.position = new Vector3(transform.position.x - (speed*Time.deltaTime), transform.position.y, transform.position.z);
        
    }

    void RandomIndex()
    {
        _i = Random.Range(0, backgrounds.Count);
        // fazer lista - randomizar lista
        // método floyd-marshall
    }
}
