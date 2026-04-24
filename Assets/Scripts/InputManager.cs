using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [Header("Input Actions Asset")]
    public InputActionAsset inputActions;

    public InputAction Jump { get; private set; }

    private void Awake()
    {
        if (inputActions == null)
        {
            Debug.LogError("InputActionAsset не назначен!");
            return;
        }

        var playerMap = inputActions.FindActionMap("PlayerControls");
        if (playerMap != null)
        {
            Jump = playerMap.FindAction("Jump");
        }
        else
        {
            Debug.LogError("Action Map 'Player' не найден!");
        }
    }

    private void OnEnable()
    {
        if (inputActions != null) inputActions.Enable();
    }

    private void OnDisable()
    {
        if (inputActions != null) inputActions.Disable();
    }
}
