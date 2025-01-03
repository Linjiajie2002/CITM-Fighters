using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private string currentAnimation = "";
    private int speed = 0;
    private int dodge = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
        ChangeAnimation("idle");
    }

    void Update()
    {
        HandleActions();
        HandleAnimationCompletion();
    }

    private void HandleActions()
    {
        // 示例：按下 N 键触发 WalkFront 动画
        if (Input.GetKeyDown(KeyCode.J))
        {
            ChangeAnimation("quick_atk");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeAnimation("slow_atk2");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            ChangeAnimation("low_quick_atk");
        }

        

        // 示例：按下 J 键触发 QuickAttack 动画
        if (Input.GetKeyDown(KeyCode.S) && speed == 0)
        {
            dodge = 1;
        }

        // 示例：按下 J 键触发 QuickAttack 动画
        if (Input.GetKeyUp(KeyCode.S))
        {
            dodge = 0;
        }

        // 示例：按下 J 键触发 QuickAttack 动画
        if (Input.GetKeyUp(KeyCode.W))
        {
            ChangeAnimation("dodge_low");
        }


        // 示例：按下 J 键触发 QuickAttack 动画
        if (Input.GetKeyDown(KeyCode.D))
        {
            speed = 1;
        }

        if (Input.GetKeyDown(KeyCode.A) && dodge == 0)
        {
            speed = -1;
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            speed = 0;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeAnimation("idle");
        }

        if (dodge != 0 )
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
        // 获取当前动画状态
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // 如果动画播放完毕并且不是 Idle 状态，切换回 Idle
        if (stateInfo.normalizedTime >= 1.0f && !stateInfo.IsName("idle") && speed == 0 && dodge == 0)
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
