using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground") {
            crashEffect.Play();
            Invoke("ReloadScene", 0.2f);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Rock") {
            crashEffect.Play();
            Invoke("ReloadScene", 0.2f);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
