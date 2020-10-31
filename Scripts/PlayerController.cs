using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    private CharacterController cc;
    public float moveSpeed;
    public float jumpSpeed;
    public float dashSpeed;
    private float originMoveSpeed;

    private float horizontalMove, verticalMove;
    private Vector3 dir;

    public float gravity;
    private Vector3 velocity;

    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;
    public bool isGround = true;

    public static bool isEnded=false;

    public int score;
    public int health;


    private void Start () {
        cc = GetComponent<CharacterController> ();
        originMoveSpeed = moveSpeed;
    }

    private void Update () {
        horizontalMove = Input.GetAxis ("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis ("Vertical") * moveSpeed;

        dir = transform.forward * verticalMove + transform.right * horizontalMove;
        cc.Move (dir * Time.deltaTime);

        if (Input.GetButtonDown ("Jump") && isGround) {
            velocity.y = jumpSpeed;
        }

        velocity.y -= gravity * Time.deltaTime;
        cc.Move (velocity * Time.deltaTime);

        //按左shift冲刺
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = dashSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = originMoveSpeed;
        }

        //游戏结束允许刷新游戏
        score = Score_Value.value;
        health = Health_Value.value;
        if (health <= 0)
        {

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            isEnded = true;
            
        }
        if (isEnded && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            isEnded = false;
            Score_Value.value = 0;
            Health_Value.value = 100;
            SceneManager.LoadScene(1);
        }

        if (isEnded && Input.GetKeyDown(KeyCode.B))
        {
            Time.timeScale = 1;
            isEnded = false;
            Score_Value.value = 0;
            Health_Value.value = 100;
            SceneManager.LoadScene(0);
        }
    }
}