using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float restartDelay = 10f;

    Animator anim;
    float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
            restartTimer += Time.deltaTime;
            if(restartTimer>= restartDelay)
            {
                RestartLevel();
            }
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
