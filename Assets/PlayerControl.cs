using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;
    public float jumpForce;
    public Rigidbody rigidBody;
    public int score;
    public TextMeshProUGUI scoreText;

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0,0,translation);
        transform.Rotate(0, rotation, 0);

        scoreText.text = score.ToString();

        if (Input.GetButton("Jump"))
        {
            rigidBody.AddForce(new Vector3(0,jumpForce,0),ForceMode.Impulse);
        }

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed));
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * (Time.deltaTime * moveSpeed));
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * (Time.deltaTime * moveSpeed));
        //}
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    transform.Rotate(Vector3.up * (Time.deltaTime * rotSpeed));
        //}

    }
    public void SpeedUpFunction()
    {
        StartCoroutine(SpeedUpDuration());
    }

    public IEnumerator SpeedUpDuration()
    {
        Debug.Log("Show that it started");
        yield return new WaitForSeconds(1f);
        moveSpeed /= 1.5f;
        Debug.Log("Show that it finished");
    }
}
