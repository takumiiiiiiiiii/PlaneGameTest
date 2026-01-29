using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    bool turnLeft, turnRight,turnUp,turnDown;
    public float moveSpeed = 10;
    public float MaxSpeed = 20;
    public float RotateSpeed = 10;
    
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManager();
        Move();
    }


    void InputManager()
    {
        if (Input.GetKey(KeyCode.A))
        {
            turnLeft = true;
        }
        else
        {
            turnLeft = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            turnRight = true;
        }
        else
        {
            turnRight = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            turnUp = true;
        }
        else
        {
            turnUp = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            turnDown = true;
        }
        else
        {
            turnDown = false;
        }

    }
    private void Move()
    {

        if (turnLeft)
        {
            this.transform.Rotate(Vector3.up, -RotateSpeed * Time.deltaTime);
        }
        if (turnRight)
        {
            this.transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);

        }
        if (turnUp)
        {
            this.transform.Rotate(Vector3.right, -RotateSpeed * Time.deltaTime);
        }
        if (turnDown)
        {
            this.transform.Rotate(Vector3.right, RotateSpeed * Time.deltaTime);
        }
        transform.position += transform.forward * Time.deltaTime;
        //rb.AddForce(transform.forward * moveSpeed);


    }
}
