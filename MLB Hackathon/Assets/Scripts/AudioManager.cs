//Merged from Jonathan Palmer (Jon@JonathanPalmerGD.com) and Joseph Constantakis (constanj@umich.edu) 
//Website: www.JonathanPalmerGD.com , https://github.com/jconst/Unity-AudioManager
//Documentation: http://www.jonathanpalmergd.com/2015/04/05/unity-simple-audiomanager/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;


/// <summary>
/// This audio manager creates "Sound" class objects and calls update on them.  Exposes two methods to create Sound/audio objects...
/// </summary>
public class AudioManager : MonoBehaviour
{

    public static AudioManager instance = null;

    void Awake() {
        #region Singleton Setup
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
        #endregion
    }


    //public static AudioManager Main {
    //    get {
    //        return   CallConvThiscall.gameObject.GetComponent<AudioManager>();
    //    }
    //}

    public HashSet<Sound> sounds = new HashSet<Sound> ();

    #region Methods to Create Sound objects
    /// Creates a new sound, registers it, gives it the properties specified, and starts playing it
    public Sound PlayNewSound(string soundName, bool loop=false, bool interrupts=false, Action<Sound> callback=null, Vector3 pos = default(Vector3)) {
        Sound sound = NewSound(soundName, loop, interrupts, callback, pos);
        sound.playing = true;
        return sound;
    }

    /// Creates a new sound, registers it, and gives it the properties specified
    public Sound NewSound(string soundName, bool loop=false, bool interrupts=false, Action<Sound> callback=null, Vector3 pos = default(Vector3)) {
        Sound sound = new Sound(soundName);
        RegisterSound(sound,pos);
        sound.loop = loop;
        sound.interrupts = interrupts;
        sound.callback = callback;
        return sound;
    }
    #endregion

    /// Registers a sound with the AudioManager and gives it an AudioSource if necessary
    /// You should probably avoid calling this function directly and just use 
    /// NewSound and PlayNewSound instead
    public void RegisterSound(Sound sound, Vector3 pos = default(Vector3)) {
        if (pos == default(Vector3))
        {
            sounds.Add(sound);
            sound.audioManager = this;
            if (sound.source == null)
            {
                AudioSource source = gameObject.AddComponent<AudioSource>();
                source.clip = sound.clip;
                sound.source = source;
            }
        }
        else
        {
            //Create empty GameObject with audiosource
            sounds.Add(sound);
            
            sound.audioManager = this;

            GameObject newAudSourceGO = new GameObject(sound.name);
            newAudSourceGO.transform.position = pos;
            AudioSource source = newAudSourceGO.AddComponent<AudioSource>() ;

            //Changes to 3D sound
            source.spatialBlend = 1;

            //Changes the distance sound can be heard
            source.minDistance= .2f;
            source.maxDistance = 1.1f;
            source.clip = sound.clip;
            sound.source = source;
        }
        
    }
    
    /// <summary>
    /// Call update on each sound object, which determines if audio object should loop or stop playing.
    /// </summary>
    private void Update() {
        sounds.ToList().ForEach(sound => {
            sound.Update();                 
        });
    }
}
