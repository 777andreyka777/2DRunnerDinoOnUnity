using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int lifeScore = 3;   
    public GameObject gameOver;
    public Text life;
    public Transform groundCheck;
    public LayerMask groundMask;
    private bool ground = false;
    private float groundRadius = 0.5f;
    void Start()
    {
        
    }

    private void Update()
    {
        ground = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);
        if (Input.GetMouseButtonDown(0) && ground == true) {
            Jump();
        }
        if (lifeScore == 0){
            gameOver.SetActive(true);
        }
    }

    public void Jump(){
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,300));
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag=="Enemy"){
            lifeScore--;
            life.text = lifeScore.ToString();
        }
    }

    public void Restart(){
        SceneManager.LoadScene("Demo");
    }
}
