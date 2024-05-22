using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public GameObject startpanel, gamepanel, gameoverpanel, creditspanel, pausepanel, nasiloynanirpanel;

    private void Awake()
    {
        score = 0;
    }

    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Toplam skorunuz : " + score;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "a" &&
            this.gameObject.GetComponent<SpriteRenderer>().sprite.name == "a")
        {
            score = score + 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "i" &&
                 this.gameObject.GetComponent<SpriteRenderer>().sprite.name == "i")
        {
            score = score + 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "k" &&
                 this.gameObject.GetComponent<SpriteRenderer>().sprite.name == "k")
        {
            score = score + 1;
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
            gamepanel.SetActive(false);
            gameoverpanel.SetActive(true);
        }
    }

    public void GameStart()
    {
        startpanel.SetActive(false);
        gamepanel.SetActive(true);
        Time.timeScale = 1.0f;
    }

    public void restart()
    {
        gameoverpanel.SetActive(false);
        gamepanel.SetActive(true);
        Time.timeScale = 1.0f;
        score = 0;
    }

    public void anamenu()
    {
        Time.timeScale = 1.0f;
        score = 0;
        nasiloynanirpanel.SetActive(false);
        gameoverpanel.SetActive(false);
        creditspanel.SetActive(false);
        pausepanel.SetActive(false);
        startpanel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}