using Unity.VisualScripting;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpStrength = 5f;
    public LogicManager Logic;
    public bool BirdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
        {
            rb.velocity = Vector2.up * JumpStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.GameOver();
        BirdIsAlive = false;
    }
}
