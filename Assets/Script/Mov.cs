
using UnityEngine;
using UnityEngine.InputSystem;

public class Mov : MonoBehaviour
{
    public float velocidadHorizontal = 8f;
    public float velocidadVertical = 4f;

    private Rigidbody2D rb;
    private float inputX;
    private float inputY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        // Movimiento Horizontal (A/D)
        inputX = 0f;
        if (keyboard.dKey.isPressed) inputX += 1f;
        if (keyboard.aKey.isPressed) inputX -= 1f;

        // Movimiento Vertical (W/S)
        inputY = 0f;
        if (keyboard.wKey.isPressed) inputY += 1f;
        if (keyboard.sKey.isPressed) inputY -= 1f;
    }

    void FixedUpdate()
    {
        // En Unity 6 se usa linearVelocity
        rb.linearVelocity = new Vector2(
            inputX * velocidadHorizontal,
            inputY * velocidadVertical
        );
    }
}
