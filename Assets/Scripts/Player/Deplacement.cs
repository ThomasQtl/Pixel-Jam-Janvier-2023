using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public Animator _animator;
    public SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>(); 
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.flipX = true;
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        /*if (!Mathf.Approximately(0, movement)) {
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }*/
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f) 
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        Flip(movement);
        float characterVelocity = Mathf.Abs(movement);
        _animator.SetFloat("Speed", characterVelocity);
        float characterVelocityY = Mathf.Abs(_rigidbody.velocity.y);
        _animator.SetFloat("SpeedY", characterVelocityY);
        if (Input.GetKeyDown(KeyCode.Keypad5)) 
            _animator.SetBool("Death", true);
    }

    void Flip(float movement)  
    {
        if (movement > 0.08f) 
        {
            _spriteRenderer.flipX = false;
        } 
        else if (movement < -0.08f) 
        {
            _spriteRenderer.flipX = true;
        }
    }
}
