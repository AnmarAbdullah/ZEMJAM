using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI launchTimer;
    public TextMeshProUGUI lossText;
    float seconds = 60;
    float minute = 5;

    [Header("Player Controlller")]
    Rigidbody rb;
    [SerializeField] float speed;
    AudioSource audioSource;

    public Camera cam;
    [SerializeField] float sensitivity;
    float rotationX;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI pressFText;

    [Header("Time Travel Schtuff")]
    bool inPast;
    [SerializeField] GameObject PresentMap;
    [SerializeField] GameObject PastMap;
    public GameObject uiAnim;
    bool isTping;
    float timer;

    void Start()
    {
        seconds = 59;
        minute = 4;
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        seconds -= Time.deltaTime;
        if(seconds < 0)
        {
            minute--;
            seconds = 59;
        }

        launchTimer.text = $"{minute}:{(int)seconds} Until Missle Launch";

        if(minute == -1)
        {
            lossText.gameObject.SetActive(true);
        }

        // Camera Movement       
        float yaw = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;
        float pitch = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;

        // pitch = Mathf.Clamp(pitch, 90, -90);

        rotationX -= pitch;

        rotationX = Mathf.Clamp(rotationX, -90, 70);
        cam.transform.localEulerAngles = new Vector3(rotationX, 0, 0f);

        transform.Rotate(Vector3.up * yaw);
        

        // Teleport Key Detection
        if(Input.GetKeyDown(KeyCode.E)) Teleport();

        // Interctable Raycast System
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 1.3f))
        {
            if(hit.collider.GetComponent<Interactable>() != null)
            {
                pressFText.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    Interactable interactable = hit.collider.GetComponent<Interactable>();
                    interactable.Interaction();
                }
            }
        }
        else
        {
            pressFText.gameObject.SetActive(false);
        }
        if (isTping)
        {
            timer += Time.deltaTime;
            uiAnim.SetActive(true);
            uiAnim.GetComponent<Animation>().Play();
            if (timer >= 0.20f)
            {
                uiAnim.SetActive(false);
                isTping = false;
                timer = 0;
            }
        }

        if (rb.velocity.magnitude > 1)
        {
            audioSource.Play();
            Debug.Log("Moving");
        }
        else audioSource.Stop();
    }

    private void FixedUpdate()
    {
        // Player Movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 direction = (transform.forward * y + transform.right * x).normalized;
        rb.velocity = direction * speed;
    }

    void Teleport()
    {
        if (!inPast) TravelTo(PastMap);
        else { TravelTo(PresentMap); };   
    }

    void TravelTo(GameObject map)
    {
        if (!isTping)
        {
            isTping=true;
            Vector3 localPos = transform.localPosition;
            transform.parent = null;
            transform.parent = map.transform;
            transform.localPosition = localPos;
            i 
        }    
    }
}
