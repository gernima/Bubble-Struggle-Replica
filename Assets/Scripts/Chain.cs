using UnityEngine;

public class Chain : MonoBehaviour
{
    public Transform player;

    public float speedChain = 1f;

    public static bool isFired = false;

    // Start is called before the first frame update
    void Start()
    {
        isFired = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isFired = true;
        }

        if (isFired)
        {
            Activate();
        }
        else
        {
            Disactivate();
        }

    }
    void Disactivate()
    {
        transform.position = player.position;
        transform.localScale = new Vector3(1, 0, 1);
    }
    void Activate()
    {
        transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speedChain;
    }
}
