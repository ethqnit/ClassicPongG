using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour
{

	public string url;
	WWW www;
	AudioClip clipFromWeb;

	IEnumerator Start ()
	{
		www = new WWW (url);
		yield return www;

		clipFromWeb = www.GetAudioClip (false);

		AudioSource source = GetComponent<AudioSource> ();
		source.clip = clipFromWeb;
		source.Play ();
	}
}