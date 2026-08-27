using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Canvas canvasMenu;
    [SerializeField] private Canvas canvasOptions;
    [SerializeField] private Canvas canvasControls;

    private bool isMenuOn;

    void Start()
    {
        canvasMenu.enabled = false;
        canvasOptions.enabled = false;
        canvasControls.enabled = false;
        isMenuOn = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isMenuOn)
            {
                canvasMenu.enabled = true;
                isMenuOn = true;
            }
            else
            {
                canvasMenu.enabled = false;
                canvasOptions.enabled = false;
                canvasControls.enabled = false;
                isMenuOn = false;
            }
        }
    }

    public void Play()
    {
        canvasMenu.enabled = false;
        isMenuOn = false;
    }

    public void OpenOptionsMenu()
    {
        canvasMenu.enabled = false;
        canvasOptions.enabled = true;
    }

    public void CloseOptionsMenu()
    {
        canvasMenu.enabled = true;
        canvasOptions.enabled = false;
    }

    public void OpenControlsMenu()
    {
        canvasMenu.enabled = false;
        canvasControls.enabled = true;
    }

    public void CloseControlsMenu()
    {
        canvasMenu.enabled = true;
        canvasControls.enabled = false;
    }
}
