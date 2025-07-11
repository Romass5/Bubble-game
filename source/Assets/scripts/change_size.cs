using UnityEngine;
using UnityEngine.InputSystem;
public class change_size : MonoBehaviour
{
    public GameObject air_bar_manager;
    private Transform circle_trans;
    public Vector3 scaleChange;
    private int small_time_limit;
    [SerializeField] private int frames_required;
    public float size_max, size_min;
    void Awake()
    {
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circle_trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.qKey.IsPressed())
        {
            if (!game_manage.instance._gameOverCanvas.activeSelf)
            {
                if (circle_trans.localScale.y >= size_min && circle_trans.localScale.x >= size_min && circle_trans.localScale.z >= size_min)
                {
                    circle_trans.localScale -= scaleChange;
                    air_bar_manager.GetComponent<air_manage>().Decrease();
                }
            }
        }
        else if (Keyboard.current.eKey.IsPressed())
        {
            if (!game_manage.instance._gameOverCanvas.activeSelf)
            {
                if (circle_trans.localScale.y <= size_max && circle_trans.localScale.x <= size_max && circle_trans.localScale.z <= size_max)
                {
                    circle_trans.localScale += scaleChange;
                    air_bar_manager.GetComponent<air_manage>().Increase();
                }
            }
        }
    }
}
