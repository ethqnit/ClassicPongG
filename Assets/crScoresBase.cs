using UnityEngine;
using System.Collections;

abstract public class crScoresBase : MonoBehaviour {

	public string
		onlinePHPURL	= "http://www.mysite.com/leaderboard.php",
		localPHPURL		= "localhost/leaderboard.php";

	public bool
		online	= true;	//is the scrip running on the local machine or online web space?

	public int				
		guiID			= 0;	//used by GUI.Window to determine drawing order. Not terribly important but can't have two windows with same id.

	public Rect 		//where to display this table
		windowRect		= new Rect(50,50,400,400);
	
	public bool scriptEnabled	{ get; set; } //show the scores or not
	
	protected string URL 		{ get { return online ? onlinePHPURL : localPHPURL; } }

	protected Vector2				
		scrollPosition	= Vector2.zero; //used by GUI.Scrollview
	
	protected float
		windowHeight = 0f;
	
	protected string	//store results as a single string to reduce draw calls
		_names = "",
		_scores = "";

	public void GetScores()
	{
		StartCoroutine( _GetScores () );
	}

	public void SubmitScore(string name, int score)
	{
		StartCoroutine( _SubmitScore (name, score) );
	}

	IEnumerator _GetScores()
	{
		WWW w = new WWW(URL + "?action=1&online="+ (online ? 1 : 0));
		yield return w;
		
		if (w.error != null)
		{
			Debug.Log("Something went wrong\n"+w.error);
		} else
		{
			scriptEnabled = false;
			
			string[] args =  w.text.Split(':');
			if (args[0] != "0")
			{
				Debug.Log(w.text + "\nThere were no scores returned!!!");
				args = new string[]{"MyBad Studios=100000"};
			}
			
			_names = _scores = string.Empty;
			for (int i = 1; i < args.Length; i++)
			{
				string[] fields = args[i].Split('=');
				_names += fields[0] + '\n';
				_scores += fields[1] + '\n';
			}			
			
			//remove final "\n"
			_names.Remove(_names.Length-1);
			_scores.Remove(_scores.Length-1);
			
			windowHeight = args.Length * 16f;
			scriptEnabled = true;
		}
	}

	IEnumerator _SubmitScore(string name, int score)
	{
		WWWForm form	= new WWWForm();
		form.AddField("action","0");
		form.AddField("online",online ? 1 : 0);
		form.AddField("playername",name);
		form.AddField("score",score.ToString());
		
		WWW w = new WWW(URL, form);
		yield return w;
		
		if (w.error != null)
		{
			Debug.Log("Something went wrong while submitting the score");
		} else
		{
			Debug.Log("Results from SubmitScore\n"+ w.text);
		}
	}

	protected void Board (int windowID)
	{
		scrollPosition = GUI.BeginScrollView (new Rect (10f,30f,windowRect.width-20f, windowRect.height-40f), scrollPosition, new Rect (0, 0, windowRect.width - 40f, windowHeight));
		
		GUI.Label(new Rect(0, 0, windowRect.width * 0.45f, windowHeight), _names);
		GUI.Label(new Rect(windowRect.width * 0.5f, 0, windowRect.width * 0.45f, windowHeight), _scores);
		GUI.EndScrollView ();
	}

}
