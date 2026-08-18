using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScrollBackgroundScript : MonoBehaviour
{
    [SerializeField] private SpawnBackgroundScript spawnScript;
    public GameObject backgroundPrefab;
    public List<Sprite> backgrounds = new List<Sprite>(6);
    public float speed = 0.01f;
    
    private int _i;
    private SpriteRenderer _sr;
    private bool _hasUpdated1 = false;
    private bool _hasUpdated2 = false;
    
    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        RandomIndex();
        _sr.sprite = backgrounds[_i];
        _sr.sortingOrder = 1;
    }

    void Update()
    {
        if (transform.position.x <= 0 && transform.position.x > -20 && !_hasUpdated1)
        {
            _hasUpdated1 = true;
            _sr.sortingOrder = 0;
            GameObject newClone = Instantiate(backgroundPrefab, new Vector3(8.88889f * 2, 0, 0), Quaternion.identity);
        }

        if (transform.position.x <= -20 && !_hasUpdated2)
        {
            Destroy(gameObject);
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
