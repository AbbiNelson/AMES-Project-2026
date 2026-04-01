using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class pausescript : MonoBehaviour
{
    private bool isPaused;

    [SerializeField] private GameObject pauseMenu;

    public void Pause()
    {
        isPaused = true;
        pauseMenu.SetActive(true);

        Time.timeScale = 0;
    }

    public void Resume()
    {
        isPaused = false;
        pauseMenu.SetActive(false);

        Time.timeScale = 1.0f;
    }

    public void toggle(InputAction.CallbackContext ctx)
    {
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);

        Time.timeScale = isPaused ? 0 : 1;
    }
}
