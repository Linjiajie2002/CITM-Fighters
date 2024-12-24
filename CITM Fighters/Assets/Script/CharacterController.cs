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
        // ʾ�������� N ������ WalkFront ����
        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeAnimation("atak");
        }

        // ʾ�������� J ������ QuickAttack ����
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
        // ��ȡ��ǰ����״̬
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // �������������ϲ��Ҳ��� Idle ״̬���л��� Idle
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
