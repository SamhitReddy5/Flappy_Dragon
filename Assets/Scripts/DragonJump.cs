using UnityEngine;

public class DragonJump : MonoBehaviour
{
    public Vector2 JumpForce;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(JumpForce);
            GetComponent<AudioSource>().Play();
        }
    }
}
