using UnityEngine;

namespace GuaiShiLing
{
    public class CameraController : MonoBehaviour
    {
        public float moveSpeed = 5f;     // 控制相机移动的速度
        public float sensitivity = 2f;   // 控制鼠标旋转的灵敏度
        public float verticalSpeed = 2f; // 控制相机上下移动的速度

        private Vector3 rotation;

        private void Start()
        {
            rotation = transform.rotation.eulerAngles;
        }

        void Update()
        {
            // 移动相机
            MoveCamera();

            // 旋转相机
            RotateCamera();

            // 上升和下降相机
            ElevateCamera();
        }

        void MoveCamera()
        {
            float horizontalInput = Input.GetAxis("Horizontal"); // 获取水平输入（A和D键）
            float verticalInput = Input.GetAxis("Vertical");     // 获取垂直输入（W和S键）

            Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput); // 创建移动方向向量

            // 根据输入方向和速度来移动相机
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }

        void RotateCamera()
        {
            if (Input.GetMouseButton(1))
            {
                float mouseX = Input.GetAxis("Mouse X");
                float mouseY = Input.GetAxis("Mouse Y");

                // 根据鼠标的移动来计算旋转角度
                rotation.x -= mouseY * sensitivity;
                rotation.y += mouseX * sensitivity;

                // 限制上下旋转角度在-90度到90度之间，以防止相机翻转
                rotation.x = Mathf.Clamp(rotation.x, -90f, 90f);

                // 应用旋转到相机
                transform.rotation = Quaternion.Euler(rotation);
            }
        }

        void ElevateCamera()
        {
            float elevateInput = 0f;

            // 使用E键上升相机
            if (Input.GetKey(KeyCode.E))
            {
                elevateInput = 1f;
            }
            // 使用Q键下降相机
            else if (Input.GetKey(KeyCode.Q))
            {
                elevateInput = -1f;
            }

            Vector3 elevateDirection = new Vector3(0f, elevateInput, 0f); // 创建垂直移动方向向量

            // 根据输入方向和速度来上升和下降相机
            transform.Translate(elevateDirection * verticalSpeed * Time.deltaTime);
        }
    }
}
