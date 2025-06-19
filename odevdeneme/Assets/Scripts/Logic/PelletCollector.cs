using System;
using UnityEngine;
using TMPro;

public class PelletCollector : MonoBehaviour
{
    public static PelletCollector Instance;
    private PelletSpawner _pelletSpawner;
    private GameController _gameController;
    private AudioSource _audioSource;
    [SerializeField] private TextMeshProUGUI _counter;
    
    
    private int _numberToCollect;
    private int _numberCollected;
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;            
        }

        _gameController = GetComponent<GameController>();
        _pelletSpawner = GetComponent<PelletSpawner>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        _numberToCollect = _pelletSpawner.NumberToSpawn;
    }

    public void ResetCounter()
    {
        _numberCollected = 0;
        _counter.text = "0";
    }
    
    public void PelletCollected()
    {
        _audioSource.PlayOneShot(_audioSource.clip);
        _numberCollected++;
        _counter.text = _numberCollected.ToString();
        if (_numberCollected >= _numberToCollect)
        {
            _gameController.EndGame();
        }
    }
}
