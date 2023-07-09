using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerMovement : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        //randomly selects axial speeds for villager at 1st frame;
        horizontalSpeed = Random.Range(-0.5f, 0.5f);
        if(horizontalSpeed < 0)
        {
            facingRight = false;
            Flip();
        }
        else
        {
            facingRight = true;
        }
        verticalSpeed = Random.Range(-0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * verticalSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
    }

    //to flip horizontally
    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        //facingRight = !facingRight;
    }
}
