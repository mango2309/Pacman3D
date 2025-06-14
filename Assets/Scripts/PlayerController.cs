using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(mh, 0f, mv);
        playerRb.linearVelocity = move * playerSpeed;
    }
}
