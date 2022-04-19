using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 startForce;

    public GameObject nextBall;

    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(startForce, ForceMode2D.Impulse);
    }
    
    public void Split()
    {
        if (nextBall != null)
        {
            GameObject ball1 = Instantiate(nextBall, rigidbody2D.position + Vector2.right, Quaternion.identity);
            GameObject ball2 = Instantiate(nextBall, rigidbody2D.position + Vector2.left, Quaternion.identity);

            ball1.GetComponent<Ball>().startForce = new Vector2(2, 5);
            ball2.GetComponent<Ball>().startForce = new Vector2(-2, 5);
        }

        Destroy(gameObject);
    }

}
