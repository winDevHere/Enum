using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerState playerState;
    [SerializeField] KeyCode left;
    [SerializeField] float moveSpeed = 6f;
    [SerializeField] float speed;
    Rigidbody2D rb;
    float moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        var kb = Keyboard.current;
        if (kb == null) return;

        moveInput = 0f;
        if (kb.aKey.isPressed || kb.leftArrowKey.isPressed)
        {
            moveInput -= 1f;
            playerState = PlayerState.Walking;
            Debug.Log("Player is walking");
        }
        else if (kb.dKey.isPressed || kb.rightArrowKey.isPressed)
        {
            moveInput += 1f;
            playerState = PlayerState.Walking;
            Debug.Log("Player is walking");
        }
        else
        {
            moveInput = 0f;
            playerState = PlayerState.Idle;
            Debug.Log("Player is idle");
        }

        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

    }
}
