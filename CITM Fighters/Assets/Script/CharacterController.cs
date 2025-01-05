using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class CharacterController : MonoBehaviour
{
    public int PlayerIndex;
    private Animator animator;
    private string currentAnimation = "";
    private int speed = 0;
    private int dodge = 0;
    private bool die = false;
    private bool win = false;
    private int life = 100;
    public bool isMirro = false;
    void Start()
    {
        animator = GetComponent<Animator>();
        ChangeAnimation("idle");
    }

    void Update()
    {
        HandleActions();
        HandleAnimationCompletion();
        if(isMirro)
        {
            animator.SetBool("isMirro", true);
        }
    }

    //Move
    public void walkfront(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (!isMirro)
            {
                speed = 1;
            }
            else {
                speed = -1;
            }
        }
        else if (ctx.canceled)
        {
            speed = 0;
        }
    }


    public void walkBack(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (!isMirro)
            {
                speed = -1;
            }
            else
            {
                speed = 1;
            }
        }
        else if (ctx.canceled)
        {
            speed = 0;
        }
    }
    //Dodge
    public void dodgeLow(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            ChangeAnimation("dodge_low");
        }
    }

    public void dodgeHigh(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            dodge = 1;
        }
        else if (ctx.canceled)
        {
            dodge = 0;
        }

    }

    //Attack
    public void quick_atk(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Debug.Log("quickAtacj");
            ChangeAnimation("quick_atk");
        }

    }
    public void slow_atk(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            ChangeAnimation("slow_atk");
        }

    }
    public void low_quick_atk(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            ChangeAnimation("low_quick_atk");
        }
    }

    public void low_slow_atk(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            ChangeAnimation("low_slow_atk");
        }

    }


    public int getPlayerIndex() {

        return PlayerIndex;
    }
    private void HandleActions()
    {
        //// Attack
        //if (Input.GetKeyDown(KeyCode.J))
        //{
        //    ChangeAnimation("quick_atk");
        //}
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    ChangeAnimation("slow_atk");
        //}
        //if (Input.GetKeyDown(KeyCode.U))
        //{
        //    ChangeAnimation("low_quick_atk");
        //}
        //if (Input.GetKeyDown(KeyCode.I))
        //{
        //    ChangeAnimation("low_slow_atk");
        //}

        ////Win and Die
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    ChangeAnimation("die");
        //    die = true;
        //}
        //if (Input.GetKeyDown(KeyCode.V))
        //{
        //    ChangeAnimation("win");
        //    win = true;
        //}


        ////Dodge
        //if (Input.GetKeyDown(KeyCode.S) && speed == 0)
        //{
        //    dodge = 1;
        //}
        //if (Input.GetKeyUp(KeyCode.S))
        //{
        //    dodge = 0;
        //}
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    ChangeAnimation("dodge_low");
        //}



        ////Move
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    speed = 1;
        //}

        //if (Input.GetKeyDown(KeyCode.A) && dodge == 0)
        //{
        //    speed = -1;
        //}
        //if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        //{
        //    speed = 0;
        //}


        if (dodge != 0)
        {
            ChangeAnimation("dodge_high");
        }

        if (speed > 0 && dodge == 0 )
        {
            ChangeAnimation("walkfront");
        }

        if (speed < 0)
        {
            ChangeAnimation("walkback");
        }

    }

    private void HandleAnimationCompletion()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.normalizedTime >= 1.0f && !stateInfo.IsName("idle") && speed == 0 && dodge == 0 && !die && !win)
        {
            ChangeAnimation("idle");
        }
    }

    private void ChangeAnimation(string animation, float crossfade = 0.2f)
    {
        if (currentAnimation != animation)
        {
            currentAnimation = animation;
            animator.CrossFade(animation, crossfade);
        }
    }
}
