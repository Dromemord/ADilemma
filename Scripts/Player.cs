using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public class Player : MonoBehaviour
{
    public Interactable focus;

    public float movementSpeed;
    public float jumpSpeed;
    public float runMultiplier;
    public float gravity = -9.81f;
    Vector3 velocity;
    private CharacterController characterController;
    Camera cam;

    private float x;
    private float z;

    private bool jump;
    private bool sprint;

    private bool leftClick;
    private bool rightClick;
    private bool eClick;

    private bool bTmp;


    public static string saveListData;

    void Start()
    {
        saveListData = "{\"Positions\":[";

        characterController = GetComponent<CharacterController>();
        cam = Camera.main;
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        jump = Input.GetButton("Jump") && characterController.isGrounded;

        sprint = Input.GetKey(KeyCode.LeftShift);

        leftClick = Input.GetMouseButtonDown(0);

        rightClick = Input.GetMouseButtonDown(1);

        eClick = Input.GetKey(KeyCode.E);
    }

    private void FixedUpdate()
    {
        if (!GameManager.gameIsPaused)
        {
            saveListData += JsonUtility.ToJson(this.transform.position) + ","  ;

            if (characterController.isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            Vector3 movement = transform.right * x + transform.forward * z;

            characterController.Move(movement * movementSpeed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            characterController.Move(velocity * Time.deltaTime);

            if (jump)
            {
                velocity.y = Mathf.Sqrt(jumpSpeed * -2f * gravity);
            }

            if (sprint)
            {
                characterController.Move(movement * Time.deltaTime * runMultiplier);
            }

            if (leftClick)
            {


                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    RemoveFocus();
                }
            }

	    bTmp = (PlayerPrefs.GetInt("Right Click") == 1);
	    
            if (rightClick || eClick || (bTmp && leftClick))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    Interactable interactable = hit.collider.GetComponent<Interactable>();
                    if (interactable != null)
                    {
                        SetFocus(interactable);
                    }
                }
            }
        }

    }

    void SetFocus(Interactable newFocus)
    {
        if (newFocus != focus)
        {
            if (focus != null)
                focus.OnDefocused();

            focus = newFocus;
        }

        newFocus.OnFocused(transform);
    }

    void RemoveFocus()
    {
        if (focus != null)
            focus.OnDefocused();
        focus = null;
    }
}
