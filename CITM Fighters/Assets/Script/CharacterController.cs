using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private string currentAnimation = "";
    private int speed = 0;

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
        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeAnimation("atak");
        }

        // 示例：按下 J 键触发 QuickAttack 动画
        if (Input.GetKeyDown(KeyCode.D))
        {
            speed = 1;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            speed = 0;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeAnimation("idle");
        }

        if (speed > 0)
        {
            ChangeAnimation("walkfront");
        }
    }

    private void HandleAnimationCompletion()
    {
        // 获取当前动画状态
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // 如果动画播放完毕并且不是 Idle 状态，切换回 Idle
        if (stateInfo.normalizedTime >= 1.0f && !stateInfo.IsName("idle") && speed ==0)
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
