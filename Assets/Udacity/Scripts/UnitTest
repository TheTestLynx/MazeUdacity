using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Threading;


public class NewPlayModeTest {
	
	[SetUp]
	public void setUp()
	{
		// If not added, need to load each object before test
		SceneManager.LoadScene("Maze", LoadSceneMode.Additive);
	}


	[Test]
	public void NewPlayModeTestSimplePasses() {
		
		// Use the Assert class to test conditions.
		GameObject door = GameObject.Find("DoorObject");
		Assert.NotNull(door, "door object should exist");

		Door doorScript = door.GetComponent<Door>();
		Assert.NotNull(doorScript, "door script should exist");

		GameObject key = GameObject.Find("Key"); // should exist
		Key keyScript = key.GetComponent<Key>();

		GameObject keyPoof = new GameObject(); // new empty object - no sound
		Assert.True(doorScript.IsLocked(), "the door should be locked");
		keyScript.OnKeyClicked(keyPoof);
		Assert.True(!doorScript.IsLocked(), "the door should be unlocked");
	}

	//[Test]
	/*async Task anotherTest()
	{
		using (var u = new WebsocketHelper())
		{
			await u.Connect(TestConfig.WS);
		}
	}*/

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator NewPlayModeTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
