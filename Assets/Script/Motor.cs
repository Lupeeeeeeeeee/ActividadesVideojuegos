using UnityEngine;

public class CambioColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.color = Color.yellow;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.color = Color.yellow; 
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            spriteRenderer.color = Color.red;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            spriteRenderer.color = Color.orange; 
        }
    }
}