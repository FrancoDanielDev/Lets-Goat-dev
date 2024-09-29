using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int health;
    public Protagonist protagonist;
    public GameObject health_bar;
    public static GameManager Instance;
    public bool onVision = false;    
    public bool onVictory = false;
    public bool sound;
    public float speed;
    public GameObject wall;
    public GameObject check;

    private void Awake()
    {
        Instance = this;
        MoneyCounter.Instance.counter = MoneyCounter.Instance.last_counter;

        if (GameMaster.instance.dead_check)
        {
            wall.SetActive(true);
            Destroy(check);
        }
        else
        {
            wall.SetActive(false);
        }
    }

    private void Update()
    {
        switch (health)
        {
            case 0:
                health_bar.transform.GetChild(1).gameObject.SetActive(false);
                health_bar.transform.GetChild(2).gameObject.SetActive(false);
                health_bar.transform.GetChild(3).gameObject.SetActive(false);
                SceneManager.LoadScene("GameOver");
                break;

            case 1:
                health_bar.transform.GetChild(2).gameObject.SetActive(false);
                health_bar.transform.GetChild(3).gameObject.SetActive(false);
                break;

            case 2:
                health_bar.transform.GetChild(3).gameObject.SetActive(false);
                health_bar.transform.GetChild(2).gameObject.SetActive(true);
                break;

            case 3:
                health_bar.transform.GetChild(1).gameObject.SetActive(true);
                health_bar.transform.GetChild(2).gameObject.SetActive(true);
                health_bar.transform.GetChild(3).gameObject.SetActive(true);
                break;

            default:
                break;
        }

        if (onVictory)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
