using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kassi : MonoBehaviour
{
    Text countText;
    private static int count;
    public GameObject sprenging;
    void Start()
    {
        countText = FindObjectOfType<Text>();
       //sprenging= GetComponent<Explosion>
        count = 1;
        SetCountText();
    }
    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }

        if (count == 9)
        {
            Debug.Log("Victory");
            SceneManager.LoadScene(3);
        }

        if (count == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "bullet")
        {
            Debug.Log("varð fyrir kúlu");
            count = count + 1;//færð stig
            SetCountText();//kallar í aðferðina
            Sprengin();
            Destroy(gameObject);
        }

        if (collision.collider.tag == "Player")
        {
            count -= 1;
            SetCountText();      
        }

        

    }

    void SetCountText()//hér er aðferðin
    {
        countText.text = "Stig: " + count.ToString();
    }
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}

/*
 Debug.Log("Touch Coin");
            count += 2;
            SetCountText();
*/