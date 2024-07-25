using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PAUSE : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool IsPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        IsPaused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }
    public void resume_button()
    {
        if (IsPaused)
        {
            resumeGame();
        }
        else
        {
            pauseGame();
        }
    }
    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void main_menu()
    {
        dalga.gecenSure = 0f;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void retray_menu()
    {
        dalga.a = 20f;
        dalga.a2 = 20f;
        dalga.a3 = 1f;
        dalga.a4 = 20;
        dalga.a5 = 20;
        dalga.a6 = 40;
        dalga.a7 = 20;
        dalga.a8 = 10;
        Bullet.hasar = 1f;
        bulledamege_control.damege = 0f;
        can_bar_kontrol.icerdema = 0;
        xp_control.xp_puan = 1;
        xp_control.MAX_XP = 10f;
        xp_control.xp = 0f;
        bullet_speed_setter.speed = 0;
        bullet_frequency.freq = 0f;
        bullet_speed_setter.speed = 0f;
        charecter_speed_control.speed = 0f;
        dalga.sayac = 0f;
        Gun.bulletSpeed = 15f;
        Gun.bulletTime = 1f;
        MoveForward.speed = 0.07f;
        dusman_dogum.spawnTime = 5f;
        dusman_dogum.spawnTime2 = 90f;
        dusman_dogum.spawnTime3 = 150f;
        dusman_dogum.spawnTime4 = 300f;
        dusman_dogum.spawnTime5 = 350f;
        dusman_dogum.spawnTime6 = 465f;
        dusman_dogum.spawnTime7 = 520;
        dusman_dogum.spawnTime8 = 560;
        SceneManager.LoadScene(1);
    }
}
