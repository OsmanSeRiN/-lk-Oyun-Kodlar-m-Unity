public class Enemy : MonoBehaviour
{
      public float Health;
      public float Damage;

      bool colliderBusy= false;
      public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = Health;
        slider.value = Health;
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
   {  
    
       if(other.tag=="Player" && !colliderBusy )

       { 
        
        other.GetComponent<sc>().GetDamage(Damage);
       }
       else if (other.tag == "Saw")
       {
          GetDamagex(other.GetComponent<Attack_Damage>().AttackDamage);
          Destroy(other.gameObject);
       }
    }
     public void GetDamagex(float damage)
    {
        if ((Health - damage)>=0)
        {
            Health -= damage;
        }
        else
        {
            Health = 0;
        }
        Idead();
        slider.value=Health;
    }
    void Idead()
    {
        if(Health <= 0)
        {
            DataManager.Instance.EnemyKilled++;
           Destroy(gameObject);
          
        }
    }