using UnityEngine;

public class SmoothCameraMovement : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(-5.0f, 2.0f, 10.0f); 
    public Quaternion startRotation = Quaternion.Euler(10f, -30f, 0f);

    public Vector3 targetPosition = new Vector3(0.0f, 1.0f, 9.0f); 
    public Quaternion targetRotation = Quaternion.Euler(0f, 0f, 0f); 

    public float moveDuration = 3.0f; 

    private float elapsedTime = 0.0f; 
    private bool isMoving = false;

    void Start()
    {
        
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

    void Update()
    {
        // 按键触发运镜（例如按下空格键）
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            isMoving = true;
            elapsedTime = 0.0f; 
        }

        
        if (isMoving)
        {
            elapsedTime += Time.deltaTime; 

            
            float progress = Mathf.Clamp01(elapsedTime / moveDuration);

            
            transform.position = Vector3.Lerp(startPosition, targetPosition, progress);
            transform.rotation = Quaternion.Lerp(startRotation, targetRotation, progress);

           
            if (progress >= 1.0f)
            {
                isMoving = false;
            }
        }
    }
}
