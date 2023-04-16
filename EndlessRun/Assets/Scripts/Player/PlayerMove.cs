using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{ 
    
    public float moveSpeed = 4;
    public float leftRightSpeed = 4;
    public static bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;


    void Update()
    {
        //Player goes forward continuously /->
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (canMove == true)
        {

            // Jobbra balra a nyilakkal 
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
                //+ A/D billentyuvel
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                }

            }

            //ugralas

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if (isJumping == false )
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Sword And Shield Jump");
                    StartCoroutine(JumpSequence());

                    moveSpeed *= 1.3f;
                }
            }

        }
        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 1.85f, Space.World);
            }
            else if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -1.85f, Space.World);
            }

        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.55f);
        comingDown = true;
        yield return new WaitForSeconds(0.55f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Sword And Shield Run");
        moveSpeed /= 1.3f;
    }

}
