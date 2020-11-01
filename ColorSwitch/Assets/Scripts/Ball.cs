using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public string pcolor;
    public Color Blue, Yellow, Pink, Purple;    
    public float force;
    public int score;
    public GameDriver g;
    public Text printing;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        chooseRandomColor();
    }
    void chooseRandomColor()
    {
        int index = Random.Range(0, 3);
        switch (index)
        {
            case 0:
                sr.color = Blue;
                pcolor = "Blue";
                break;
            case 1:
                sr.color = Pink;
                pcolor = "Pink";
                break;
            case 2:
                sr.color = Yellow;
                pcolor = "Yellow";
                break;
            case 3:
                sr.color = Purple;
                pcolor = "Purple";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, 1 * force);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log(collision.name);
        
        if(collision.name == "bar")
        {
            rb.velocity = new Vector2(0, 1 * force);
            return;
        }

        if(collision.name == "ColorChanger" )
        {
            string temp = pcolor;
            while(temp == pcolor)
            {
                chooseRandomColor();
            }
            //Destroy(collision.gameObject);
            g.spawner();

            return;
        }
        if (collision.name == "Star")
        {
            score+=10;
            printing.text = "Score : " + score;
            Destroy(collision.gameObject);
            return;
        }
        if (collision.name !=  pcolor)
        {
            score = 0;
            printing.text = "Score : " + score;
            SceneManager.LoadScene(0); 
        }
    }
}
