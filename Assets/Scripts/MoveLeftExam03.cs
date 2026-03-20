using UnityEngine;

public class MoveLeft03 : MonoBehaviour
{
    public float speed = 10f;

    private float leftBound = -15;

    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.gameOver)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (playerController.isDashing)
            {
                transform.Translate(Vector2.left * (speed * 1.5f) * Time.deltaTime);
                
            }
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        
    }
}
