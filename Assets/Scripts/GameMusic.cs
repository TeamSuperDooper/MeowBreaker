using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class GameMusic : MonoBehaviour {

	public AudioMixerSnapshot DyingKitty;
	public AudioMixerSnapshot BackgroundMusic;

	private float m_TransitionIn;
	private float m_TransitionOut;
	private float m_QuarterNote;

	// Use this for initialization
	void Start () {
		m_QuarterNote = 60 / 128;
		m_TransitionIn = m_QuarterNote;
		m_TransitionOut = m_QuarterNote * 32;
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("BallMusic")) {
			DyingKitty.TransitionTo(m_TransitionIn);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("BallMusic")) {
			BackgroundMusic.TransitionTo(m_TransitionOut);
		}
	}
			
}
