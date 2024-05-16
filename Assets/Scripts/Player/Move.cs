using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float rightLeftSpeed = 4f;
    private CharacterController characterController;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject chModel;
    private Animator animator;
    static public bool canMove = false;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = chModel.GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * rightLeftSpeed);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * rightLeftSpeed * -1);
                }
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    chModel.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }

            if (isJumping == true)
            {
                Vector3 jumpDirection = transform.TransformDirection(Vector3.forward); // Получаем направление прыжка вперед
                float jumpSpeed = 4f;

                if (comingDown == false)
                {
                    characterController.Move(jumpDirection * jumpSpeed * Time.deltaTime + Vector3.up * 2 * Time.deltaTime);
                }

                if (comingDown == true)
                {
                    characterController.Move(jumpDirection * jumpSpeed * Time.deltaTime + Vector3.up * -2 * Time.deltaTime);
                }
            }
        }
    }

    IEnumerator JumpSequence()
    {
        float initialHeight = transform.position.y;
        yield return new WaitForSeconds(0.40f);
        comingDown = true;
        yield return new WaitForSeconds(0.40f);
        isJumping = false;
        comingDown = false;

        chModel.GetComponent<Animator>().Play("Standard Run");
        transform.position = new Vector3(transform.position.x, initialHeight, transform.position.z);
    }
}
