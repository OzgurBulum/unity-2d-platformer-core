using UnityEngine;
using UnityEngine.EventSystems;

public class MobileInputHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum ButtonType { Left, Right, Jump }
    public ButtonType buttonType;

    private PlayerMovement playerMovement;
    
    void Start()
    {
        playerMovement = FindFirstObjectByType<PlayerMovement>();

        if (playerMovement == null)
        {
            Debug.LogError("MobileInputHandler: PlayerMovement not found!");
        }
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        switch (buttonType)
        {
            case ButtonType.Left:
                playerMovement.SetMobileLeft(true);
                break;
            case ButtonType.Right:
                playerMovement.SetMobileRight(true);
                break;
            case ButtonType.Jump:
                playerMovement.SetMobileJump(true);
                break;
        }
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        switch (buttonType)
        {
            case ButtonType.Left:
                playerMovement.SetMobileLeft(false);
                break;
            case ButtonType.Right:
                playerMovement.SetMobileRight(false);
                break;
            case ButtonType.Jump:
                playerMovement.SetMobileJump(false);
                break;
        }
    }
}