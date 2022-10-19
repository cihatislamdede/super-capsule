using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int score = 0;
    [SerializeField] Text scoreText;
    [SerializeField] AudioSource collectSound;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Coin")) {
            Destroy(other.gameObject);
            updateScore();
            collectSound.Play();
        }
    }    

    public void updateScore() {
        score++;
        scoreText.text = "Score:  " + score.ToString();
    }
}
