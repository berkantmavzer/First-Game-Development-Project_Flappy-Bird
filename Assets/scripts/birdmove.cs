using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdmove : MonoBehaviour
{

    public bool isdead;
    public float velocity = 1f;
    public Rigidbody2D rgb2D;

    public GameManager managerGame;
    public GameObject DeathScreen;

    public AudioSource olumSes;
    public AudioSource ziplamaSes;
    public AudioSource skorSes;



    private void Start()
    {

        isdead = false;

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rgb2D.velocity = Vector2.up * velocity;

            ziplamaSes.mute = false;
            ziplamaSes.Play();
        }

        float yPozisyon = Mathf.Clamp(transform.position.y,-0.829f, 1.212f);
        transform.position = new Vector2(transform.position.x, yPozisyon);

        if (Time.timeScale == 0)
        {
            olumSes.mute = true;
            ziplamaSes.mute = true;
            skorSes.mute = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
            skorSes.mute = false;
            skorSes.Play();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            isdead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);

            olumSes.mute = false;
            olumSes.Play();
        }
    }
}
