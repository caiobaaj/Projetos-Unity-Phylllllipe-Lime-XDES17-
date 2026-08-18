using UnityEngine;
using UnityEngine.InputSystem;

public class NaveAula4 : MonoBehaviour
{
    [SerializeField] private float ySpeed;
    [SerializeField] private GameObject laserPrefab;
    
    private Rigidbody2D _rb;
    private float _yDir;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        Instantiate(laserPrefab, transform.position, Quaternion.identity);
    }
    
    void FixedUpdate()
    {
        Movimentar();
    }

    void Movimentar()
    {
        //Aplicar o movimento do corpo rígido
        _rb.linearVelocityY = _yDir*ySpeed;
    }
    
    //Chamado pelo PlayerInput -> Move
    void OnMove(InputValue inputValue) 
    {
        print(inputValue.Get<Vector2>());
        //Direção do movimento em y: 0, 1 e -1
        _yDir = inputValue.Get<Vector2>().y;
        
    }

    //Chamado pelo PlayerInput -> Attack
    void OnAttack()
    {
        //Pressionar espaço
        //Gerar nova munição
        Instantiate(laserPrefab, transform.position, Quaternion.identity);
        //Munição sai voando
        //Legal
    }
}
