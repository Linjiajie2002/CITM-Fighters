using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputAndRumbleManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private CharacterController _playerController;
    // Start is called before the first frame update


    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        var PlayercControllers = FindObjectsOfType<CharacterController>();
        _playerController = PlayercControllers.FirstOrDefault(m => m.getPlayerIndex() == _playerInput.playerIndex);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Move
    public void walkfront(InputAction.CallbackContext ctx)
    {
        if (_playerController != null)
        {
            _playerController.walkfront(ctx);

        }
    }


    public void walkBack(InputAction.CallbackContext ctx)
    {
        if (_playerController != null)
        {
            _playerController.walkBack(ctx);

        }
    }

    //Dodge
    public void dodgeLow(InputAction.CallbackContext ctx)
    {
        if (_playerController != null)
        {
            _playerController.dodgeLow(ctx);

        }
    }

    public void dodgeHigh(InputAction.CallbackContext ctx)
    {
        if (_playerController != null)
        {
            _playerController.dodgeHigh(ctx);

        }

    }

    //Attack
    public void quick_atk(InputAction.CallbackContext ctx)
    {
        if (_playerController != null)
        {
            _playerController.quick_atk(ctx);

        }

    }
    public void slow_atk(InputAction.CallbackContext ctx)
    {
        if (_playerController != null)
        {
            _playerController.slow_atk(ctx);

        }

    }
    public void low_quick_atk(InputAction.CallbackContext ctx)
    {
        if (_playerController != null)
        {
            _playerController.low_quick_atk(ctx);

        }
    }

    public void low_slow_atk(InputAction.CallbackContext ctx)
    {
        if (_playerController != null)
        {
            _playerController.low_slow_atk(ctx);

        }

    }

}
