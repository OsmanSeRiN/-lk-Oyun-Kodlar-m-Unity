  public GameObject İnGameScreen,PauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SettingsButton() 
    {
        
    }
    public void ExitButton()
    {
        Time.timeScale = 1;
        DataManager.Instance.DataSave();
       SceneManager.LoadScene(0);
    }
    public void PauseButton()
    {
      Time.timeScale=0;
      İnGameScreen.SetActive(false);
      PauseScreen.SetActive(true);
    }
    public void ReplayButton() 
    {
        Time.timeScale = 1;
     SceneManager.LoadScene(1);
    }
    public void PlayButton()
    {
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
        İnGameScreen.SetActive(true);
    }
}
