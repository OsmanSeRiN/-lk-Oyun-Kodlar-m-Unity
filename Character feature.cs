public class sc : MonoBehaviour
{    public float Health,SawSpeed;
    bool Dead = false;
    Transform Attack1;
    public Transform Saw;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        Attack1=transform.GetChild(1);
        slider.maxValue=Health;
        slider.value=Health;
       
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonUp(1))
        {
            shoot();
        }
        
    }

    public void GetDamage(float damage)
    {
        if ((Health - damage)>=0)
        {
            Health -= damage;
        }
        else
        {
            Health = 0;
        }
        amIdead();
        slider.value=Health;
    }
    void amIdead()
    {
        if(Health <= 0)
        {
            Dead=true;
        }
    }

    void shoot()
    {
        Transform tempSaw;
       tempSaw = Instantiate(Saw,Attack1.position,Quaternion.identity);
       tempSaw.GetComponent<Rigidbody2D>().AddForce(Attack1.forward * SawSpeed);
       DataManager.Instance.ShotSaw++;
    }


}
