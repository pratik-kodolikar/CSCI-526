using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_script : MonoBehaviour
{
    // public Text MyscoreText;
    public static float ScoreNum;
    
    public static float MaxHealth;
    public Slider _slide;
    public static float currentHealth;

    void Start()
    {
        //ScoreNum = 0;
        // MyscoreText.text = "Energy level : " + ScoreNum + "/10";
        MaxHealth = 10;
        currentHealth = 0;
        _slide.maxValue = MaxHealth;
        _slide.value = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("powerup"))
        {
            //ScoreNum += 0.5f;
            //Destroy(collision.gameObject);
            // MyscoreText.text = "Energy level : " + ScoreNum + "/10";
            currentHealth = currentHealth + 5;
            _slide.value = currentHealth;
            Destroy(collision.gameObject);

        }
    }
}
